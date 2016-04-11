package br.eti.francisco.mylibrary;

import android.util.Log;

/**
 * Created by Francisco on 09/04/2016.
 */
public class Helper {

    private static int i = 0;

    public static int getValue(){
        return i;
    }

    public static void doInAndroid() {
        new Thread(){
            @Override
            public void run() {
                while(true){
                    i++;
                    Log.i("Unity", "Hi, something is done in Android. " + i);
                    try {
                        Thread.sleep(1000);
                    } catch (InterruptedException e) {
                        e.printStackTrace();
                    }
                }
            }
        }.start();

    }
}
