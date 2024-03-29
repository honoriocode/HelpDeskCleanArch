﻿using HelpDesk.Application.ViewModels.TiposUsuario;
using HelpDesk.Application.ViewModels.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Application.Interfaces;

public interface ITiposUsuarioServices
{
    Task<IQueryable<ResponseTiposUsuarioViewModel>> GetAll();
    Task<ResponseTiposUsuarioViewModel> GetById(Guid id);

    Task<ServiceResponse> Edit(Guid id, RequestTiposUsuarioViewModel request);
}
