﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CapaDatos;

namespace CapaNegocio
{
    public class MaquinariasGAQ_Negocio
    {
        public void Login(String user, String password) {
            BD database = new CapaDatos.BD();
            try{
                database.Login(user, password);
            } catch (LoginException)
            {
                throw new Exception("LoginException");
            }
            catch (TooManyAttemptsException)
            {
                throw new Exception("TooManyAttemptsException");
            }
            catch(Exception)
            {
                throw new Exception("GeneralError");
            }
        }
        
    }
}
