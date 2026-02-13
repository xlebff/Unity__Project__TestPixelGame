using UnityEngine;

public class SoundPlay : MonoBehaviour
{
    public bool piano;
    public bool cat;
    public bool pig;

    [SerializeField] private AudioSource c1;
    [SerializeField] private AudioSource c_1;
    [SerializeField] private AudioSource d1;
    [SerializeField] private AudioSource d_1;
    [SerializeField] private AudioSource e1;
    [SerializeField] private AudioSource f1;
    [SerializeField] private AudioSource f_1;
    [SerializeField] private AudioSource g1;
    [SerializeField] private AudioSource g_1;
    [SerializeField] private AudioSource a1;
    [SerializeField] private AudioSource a_1;
    [SerializeField] private AudioSource h1;
    [SerializeField] private AudioSource c2;
    [SerializeField] private AudioSource c_2;
    [SerializeField] private AudioSource d2;
    [SerializeField] private AudioSource d_2;
    [SerializeField] private AudioSource e2;
    [SerializeField] private AudioSource f2;
    [SerializeField] private AudioSource f_2;
    [SerializeField] private AudioSource g2;
    [SerializeField] private AudioSource g_2;
    [SerializeField] private AudioSource a2;
    [SerializeField] private AudioSource a_2;
    [SerializeField] private AudioSource h2;
    [SerializeField] private AudioSource c3;
    [SerializeField] private AudioSource c_3;
    [SerializeField] private AudioSource d3;
    [SerializeField] private AudioSource d_3;
    [SerializeField] private AudioSource e3;
    [SerializeField] private AudioSource f3;
    [SerializeField] private AudioSource f_3;
    [SerializeField] private AudioSource g3;
    [SerializeField] private AudioSource g_3;
    [SerializeField] private AudioSource a3;
    [SerializeField] private AudioSource a_3;
    [SerializeField] private AudioSource h3;

    [SerializeField] private AudioSource cat_c1;
    [SerializeField] private AudioSource cat_c_1;
    [SerializeField] private AudioSource cat_d1;
    [SerializeField] private AudioSource cat_d_1;
    [SerializeField] private AudioSource cat_e1;
    [SerializeField] private AudioSource cat_f1;
    [SerializeField] private AudioSource cat_f_1;
    [SerializeField] private AudioSource cat_g1;
    [SerializeField] private AudioSource cat_g_1;
    [SerializeField] private AudioSource cat_a1;
    [SerializeField] private AudioSource cat_a_1;
    [SerializeField] private AudioSource cat_h1;
    [SerializeField] private AudioSource cat_c2;
    [SerializeField] private AudioSource cat_c_2;
    [SerializeField] private AudioSource cat_d2;
    [SerializeField] private AudioSource cat_d_2;
    [SerializeField] private AudioSource cat_e2;
    [SerializeField] private AudioSource cat_f2;
    [SerializeField] private AudioSource cat_f_2;
    [SerializeField] private AudioSource cat_g2;
    [SerializeField] private AudioSource cat_g_2;
    [SerializeField] private AudioSource cat_a2;
    [SerializeField] private AudioSource cat_a_2;
    [SerializeField] private AudioSource cat_h2;
    [SerializeField] private AudioSource cat_c3;
    [SerializeField] private AudioSource cat_c_3;
    [SerializeField] private AudioSource cat_d3;
    [SerializeField] private AudioSource cat_d_3;
    [SerializeField] private AudioSource cat_e3;
    [SerializeField] private AudioSource cat_f3;
    [SerializeField] private AudioSource cat_f_3;
    [SerializeField] private AudioSource cat_g3;
    [SerializeField] private AudioSource cat_g_3;
    [SerializeField] private AudioSource cat_a3;
    [SerializeField] private AudioSource cat_a_3;
    [SerializeField] private AudioSource cat_h3;

    [SerializeField] private AudioSource pig_c1;
    [SerializeField] private AudioSource pig_c_1;
    [SerializeField] private AudioSource pig_d1;
    [SerializeField] private AudioSource pig_d_1;
    [SerializeField] private AudioSource pig_e1;
    [SerializeField] private AudioSource pig_f1;
    [SerializeField] private AudioSource pig_f_1;
    [SerializeField] private AudioSource pig_g1;
    [SerializeField] private AudioSource pig_g_1;
    [SerializeField] private AudioSource pig_a1;
    [SerializeField] private AudioSource pig_a_1;
    [SerializeField] private AudioSource pig_h1;
    [SerializeField] private AudioSource pig_c2;
    [SerializeField] private AudioSource pig_c_2;
    [SerializeField] private AudioSource pig_d2;
    [SerializeField] private AudioSource pig_d_2;
    [SerializeField] private AudioSource pig_e2;
    [SerializeField] private AudioSource pig_f2;
    [SerializeField] private AudioSource pig_f_2;
    [SerializeField] private AudioSource pig_g2;
    [SerializeField] private AudioSource pig_g_2;
    [SerializeField] private AudioSource pig_a2;
    [SerializeField] private AudioSource pig_a_2;
    [SerializeField] private AudioSource pig_h2;
    [SerializeField] private AudioSource pig_c3;
    [SerializeField] private AudioSource pig_c_3;
    [SerializeField] private AudioSource pig_d3;
    [SerializeField] private AudioSource pig_d_3;
    [SerializeField] private AudioSource pig_e3;
    [SerializeField] private AudioSource pig_f3;
    [SerializeField] private AudioSource pig_f_3;
    [SerializeField] private AudioSource pig_g3;
    [SerializeField] private AudioSource pig_g_3;
    [SerializeField] private AudioSource pig_a3;
    [SerializeField] private AudioSource pig_a_3;
    [SerializeField] private AudioSource pig_h3;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) C1();
        if (Input.GetKeyDown(KeyCode.S)) C_1();
        if (Input.GetKeyDown(KeyCode.X)) D1();
        if (Input.GetKeyDown(KeyCode.D)) D_1();
        if (Input.GetKeyDown(KeyCode.C)) E1();
        if (Input.GetKeyDown(KeyCode.V)) F1();
        if (Input.GetKeyDown(KeyCode.G)) F_1();
        if (Input.GetKeyDown(KeyCode.B)) G1();
        if (Input.GetKeyDown(KeyCode.H)) G_1();
        if (Input.GetKeyDown(KeyCode.N)) A1();
        if (Input.GetKeyDown(KeyCode.J)) A_1();
        if (Input.GetKeyDown(KeyCode.M)) H1();
        if (Input.GetKeyDown(KeyCode.Comma)) C2();
        if (Input.GetKeyDown(KeyCode.L)) C_2();
        if (Input.GetKeyDown(KeyCode.Period)) D2();
        if (Input.GetKeyDown(KeyCode.Semicolon)) D_2();
        if (Input.GetKeyDown(KeyCode.Slash)) E2();
        if (Input.GetKeyDown(KeyCode.Q)) F2();
        if (Input.GetKeyDown(KeyCode.Alpha2)) F_2();
        if (Input.GetKeyDown(KeyCode.W)) G2();
        if (Input.GetKeyDown(KeyCode.Alpha3)) G_2();
        if (Input.GetKeyDown(KeyCode.E)) A2();
        if (Input.GetKeyDown(KeyCode.Alpha4)) A_2();
        if (Input.GetKeyDown(KeyCode.R)) H2();
        if (Input.GetKeyDown(KeyCode.T)) C3();
        if (Input.GetKeyDown(KeyCode.Alpha6)) C_3();
        if (Input.GetKeyDown(KeyCode.Y)) D3();
        if (Input.GetKeyDown(KeyCode.Alpha7)) D_3();
        if (Input.GetKeyDown(KeyCode.U)) E3();
        if (Input.GetKeyDown(KeyCode.I)) F3();
        if (Input.GetKeyDown(KeyCode.Alpha9)) F_3();
        if (Input.GetKeyDown(KeyCode.O)) G3();
        if (Input.GetKeyDown(KeyCode.Alpha0)) G_3();
        if (Input.GetKeyDown(KeyCode.P)) A3();
        if (Input.GetKeyDown(KeyCode.Minus)) A_3();
        if(Input.GetKeyDown(KeyCode.LeftBracket)) H3();
    }

    public void C1()
    {
        if (piano)
        {
            c1.Play();
        }
        if (cat)
        {
            cat_c1.Play();
        }
        if (pig)
        {
            pig_c1.Play();
        }
    }
    public void C_1()
    {
        if (piano)
        {
            c_1.Play();
        }
        if (cat)
        {
            cat_c_1.Play();
        }
        if (pig)
        {
            pig_c_1.Play();
        }
    }
    public void D1()
    {
        if (piano)
        {
            d1.Play();
        }
        if (cat)
        {
            cat_d1.Play();
        }
        if (pig)
        {
            pig_d1.Play();
        }
    }
    public void D_1()
    {
        if (piano)
        {
            d_1.Play();
        }
        if (cat)
        {
            cat_d_1.Play();
        }
        if (pig)
        {
            pig_d_1.Play();
        }
    }
    public void E1()
    {
        if (piano)
        {
            e1.Play();
        }
        if (cat)
        {
            cat_e1.Play();
        }
        if (pig)
        {
            pig_e1.Play();
        }
    }
    public void F1()
    {
        if (piano)
        {
            f1.Play();
        }
        if (cat)
        {
            cat_f1.Play();
        }
        if (pig)
        {
            pig_f1.Play();
        }
    }
    public void F_1()
    {
        if (piano)
        {
            f_1.Play();
        }
        if (cat)
        {
            cat_f_1.Play();
        }
        if (pig)
        {
            pig_f_1.Play();
        }
    }
    public void G1()
    {
        if (piano)
        {
            g1.Play();
        }
        if (cat)
        {
            cat_g1.Play();
        }
        if (pig)
        {
            pig_g1.Play();
        }
    }
    public void G_1()
    {
        if (piano)
        {
            g_1.Play();
        }
        if (cat)
        {
            cat_g_1.Play();
        }
        if (pig)
        {
            pig_g_1.Play();
        }
    }
    public void A1()
    {
        if (piano)
        {
            a1.Play();
        }
        if (cat)
        {
            cat_a1.Play();
        }
        if (pig)
        {
            pig_a1.Play();
        }
    }
    public void A_1()
    {
        if (piano)
        {
            a_1.Play();
        }
        if (cat)
        {
            cat_a_1.Play();
        }
        if (pig)
        {
            pig_a_1.Play();
        }
    }
    public void H1()
    {
        if (piano)
        {
            h1.Play();
        }
        if (cat)
        {
            cat_h1.Play();
        }
        if (pig)
        {
            pig_h1.Play();
        }
    }
    public void C2()
    {
        if (piano)
        {
            c2.Play();
        }
        if (cat)
        {
            cat_c2.Play();
        }
        if (pig)
        {
            pig_c2.Play();
        }
    }
    public void C_2()
    {
        if (piano)
        {
            c_2.Play();
        }
        if (cat)
        {
            cat_c_2.Play();
        }
        if (pig)
        {
            pig_c_2.Play();
        }
    }
    public void D2()
    {
        if (piano)
        {
            d2.Play();
        }
        if (cat)
        {
            cat_d2.Play();
        }
        if (pig)
        {
            pig_d2.Play();
        }
    }
    public void D_2()
    {
        if (piano)
        {
            d_2.Play();
        }
        if (cat)
        {
            cat_d_2.Play();
        }
        if (pig)
        {
            pig_d_2.Play();
        }
    }
    public void E2()
    {
        if (piano)
        {
            e2.Play();
        }
        if (cat)
        {
            cat_e2.Play();
        }
        if (pig)
        {
            pig_e2.Play();
        }
    }
    public void F2()
    {
        if (piano)
        {
            f2.Play();
        }
        if (cat)
        {
            cat_f2.Play();
        }
        if (pig)
        {
            pig_f2.Play();
        }
    }
    public void F_2()
    {
        if (piano)
        {
            f_2.Play();
        }
        if (cat)
        {
            cat_f_2.Play();
        }
        if (pig)
        {
            pig_f_2.Play();
        }
    }
    public void G2()
    {
        if (piano)
        {
            g2.Play();
        }
        if (cat)
        {
            cat_g2.Play();
        }
        if (pig)
        {
            pig_g2.Play();
        }
    }
    public void G_2()
    {
        if (piano)
        {
            g_2.Play();
        }
        if (cat)
        {
            cat_g_2.Play();
        }
        if (pig)
        {
            pig_g_2.Play();
        }
    }
    public void A2()
    {
        if (piano)
        {
            a2.Play();
        }
        if (cat)
        {
            cat_a2.Play();
        }
        if (pig)
        {
            pig_a2.Play();
        }
    }
    public void A_2()
    {
        if (piano)
        {
            a_2.Play();
        }
        if (cat)
        {
            cat_a_2.Play();
        }
        if (pig)
        {
            pig_a_2.Play();
        }
    }
    public void H2()
    {
        if (piano)
        {
            h2.Play();
        }
        if (cat)
        {
            cat_h2.Play();
        }
        if (pig)
        {
            pig_h2.Play();
        }
    }
    public void C3()
    {
        if (piano)
        {
            c3.Play();
        }
        if (cat)
        {
            cat_c3.Play();
        }
        if (pig)
        {
            pig_c3.Play();
        }
    }
    public void C_3()
    {
        if (piano)
        {
            c_3.Play();
        }
        if (cat)
        {
            cat_c_3.Play();
        }
        if (pig)
        {
            pig_c_3.Play();
        }
    }
    public void D3()
    {
        if (piano)
        {
            d3.Play();
        }
        if (cat)
        {
            cat_d3.Play();
        }
        if (pig)
        {
            pig_d3.Play();
        }
    }
    public void D_3()
    {
        if (piano)
        {
            d_3.Play();
        }
        if (cat)
        {
            cat_d_3.Play();
        }
        if (pig)
        {
            pig_d_3.Play();
        }
    }
    public void E3()
    {
        if (piano)
        {
            e3.Play();
        }
        if (cat)
        {
            cat_e3.Play();
        }
        if (pig)
        {
            pig_e3.Play();
        }
    }
    public void F3()
    {
        if (piano)
        {
            f3.Play();
        }
        if (cat)
        {
            cat_f3.Play();
        }
        if (pig)
        {
            pig_f3.Play();
        }
    }
    public void F_3()
    {
        if (piano)
        {
            f_3.Play();
        }
        if (cat)
        {
            cat_f_3.Play();
        }
        if (pig)
        {
            pig_f_3.Play();
        }
    }
    public void G3()
    {
        if (piano)
        {
            g3.Play();
        }
        if (cat)
        {
            cat_g3.Play();
        }
        if (pig)
        {
            pig_g3.Play();
        }
    }
    public void G_3()
    {
        if (piano)
        {
            g_3.Play();
        }
        if (cat)
        {
            cat_g_3.Play();
        }
        if (pig)
        {
            pig_g_3.Play();
        }
    }
    public void A3()
    {
        if (piano)
        {
            a3.Play();
        }
        if (cat)
        {
            cat_a3.Play();
        }
        if (pig)
        {
            pig_a3.Play();
        }
    }
    public void A_3()
    {
        if (piano)
        {
            a_3.Play();
        }
        if (cat)
        {
            cat_a_3.Play();
        }
        if (pig)
        {
            pig_a_3.Play();
        }
    }
    public void H3()
    {
        if (piano)
        {
            h3.Play();
        }
        if (cat)
        {
            cat_h3.Play();
        }
        if (pig)
        {
            pig_h3.Play();
        }
    }
}
