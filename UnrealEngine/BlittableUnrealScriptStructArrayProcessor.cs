using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000039 RID: 57
	public sealed class BlittableUnrealScriptStructArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T>, IScriptStructProcessor where T : struct, ValueType, IUnrealScriptStruct, IEqualityOperators<T, T, bool>
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0000D214 File Offset: 0x0000B414
		public BlittableUnrealScriptStructArrayProcessor()
		{
			this.IsStructProxyProcessor = true;
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			int num;
			UnrealReflectionUtils.GetUScriptStructProps(IUnrealScriptStruct.StaticStruct(), out this.Size, out this.MinAlignment, out num);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0000D272 File Offset: 0x0000B472
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.InitializeStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0000D290 File Offset: 0x0000B490
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DestructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.DestroyStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0000D2AE File Offset: 0x0000B4AE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UScriptStructStackOnlyPtr GetNativeScriptStructPtr()
		{
			return IUnrealScriptStruct.StaticStruct();
		}
	}
}
