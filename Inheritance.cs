//interface and inheritance

/*  ============================================================================================================================
    
    ***************************         *****     ****************************
    ************************   *        *****    *  **************************
    **                      *   *               *  *   
    **                       *   *      *****   *  *  
    **                        *   *     *   *   *  *
    **                        *   *     *   *   *  *
    **                       *   *      *   *    *  *
    ************************    *       *   *     *  *
    ************************    *       *   *      *  ***********************
    **                       *   *      *   *        ***********************   *
    **                         *   *    *   *                              *    *
    **                          *   *   *   *                                *   *
    **                           *   *  *   *                                  *  *
    **                           *   *  *   *                                  *  *
    **                          *   *   *   *                                 *   *
    ****************************   *    *   *     *****************************  *                
    *******************************     *****     *******************************
    =============================================================================================================================

*/
using System;

//declaring an interface 
public interface A{
    //method of interface
    void mythod();

    void myth();
}

//Inheriting method from interface A to interface B

public interface B:A{
    void myth2();
}
//class inheriting interface B only

class Geek:B{
    //implementing methods of both interfaces
    //of interfaceA
    public void mythod(){
        Console.WriteLine("Implement method 1");
    }

    public void myth(){
        Console.WriteLine("I am a Lonely Being!!@ :)");
    }

    //of interface B
    public void myth2(){
        Console.WriteLine("Implement Mthy2");
    }
}