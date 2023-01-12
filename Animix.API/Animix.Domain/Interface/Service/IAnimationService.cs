﻿using Animix.Domain.Model.Entity;

namespace Animix.Domain.Interface.Service
{
    public interface IAnimationService
    {
        Task<Animation> CreateAnimationAsync(Animation animation);
        Task<List<Animation>> GetAllAnimationsAsync();
        Task<Animation> GetAnimationByIdAsync(int idAnimation);
        Task<Animation> UpdateAnimationAsync(int idAnimation);
        Task<string> DeleteAnimationAsync(int idAnimation);
    }
}
