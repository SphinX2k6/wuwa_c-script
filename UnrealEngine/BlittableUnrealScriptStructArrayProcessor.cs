using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000054 RID: 84
	public sealed class BlittableUnrealScriptStructArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T>, IScriptStructProcessor where T : struct, ValueType, IUnrealScriptStruct, IEqualityOperators<T, T, bool>
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x000109A8 File Offset: 0x0000EBA8
		public BlittableUnrealScriptStructArrayProcessor()
		{
			this.IsStructProxyProcessor = true;
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			int num;
			UnrealReflectionUtils.GetUScriptStructProps(IUnrealScriptStruct.StaticStruct(), out this.Size, out this.MinAlignment, out num);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00010A06 File Offset: 0x0000EC06
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.InitializeStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00010A24 File Offset: 0x0000EC24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DestructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.DestroyStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00010A42 File Offset: 0x0000EC42
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UScriptStructStackOnlyPtr GetNativeScriptStructPtr()
		{
			return IUnrealScriptStruct.StaticStruct();
		}
	}
}
