using System.Collections;
using UnityEngine;

public class DroneGun : MonoBehaviour {

    public int droneDmg = 1;

    //Components
    private BreadcrumbAi.Ai _ai;
    private AudioSource _gunAudio;
    private LineRenderer _laserLine;

    private Vector3 _playerPosition;

    //Shooting time
    private float _nextActionTime = 0.0f;
    private float _period = 1.5f;

    public ParticleSystem particleSystem;

    private void Start() {
        particleSystem.GetComponent<ParticleSystem>();
        _ai = GetComponentInParent<BreadcrumbAi.Ai>();
        _laserLine = GetComponent<LineRenderer>();
        _gunAudio = GetComponent<AudioSource>();
    }
    private void Update() {
        
        if(_ai.attackState == BreadcrumbAi.Ai.ATTACK_STATE.CanAttackPlayer && Time.time > _nextActionTime) {
            _nextActionTime += _period;
            _playerPosition = _ai.Player.transform.position;
            Shoot();
        }
    }

    public void Shoot() {
        Vector3 raycastDir = _playerPosition - transform.position;
        RaycastHit hit;
        _laserLine.SetPosition(0, gameObject.transform.position);
        if (Physics.Raycast(gameObject.transform.position, raycastDir, out hit)) {
            PlayerController playerController = hit.transform.GetComponentInParent<PlayerController>();
            if(playerController != null)
                playerController.DmgTaken(droneDmg);

            _laserLine.SetPosition(1, hit.point);
            transform.LookAt(hit.point);
        }
        StartCoroutine(ShootEffect());
    }
        
    
    private IEnumerator ShootEffect() {
        _gunAudio.Play();
        particleSystem.Play();
        _laserLine.enabled = true;
        yield return new WaitForSeconds(0.2f);
        _laserLine.enabled = false;
        _gunAudio.Stop();
    }

}
