using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BC5 RID: 3013
	[UnrealObjectPath("/Script/Engine.ExponentialHeightFog")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AExponentialHeightFog : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060092AE RID: 37550 RVA: 0x000D2608 File Offset: 0x000D0808
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AExponentialHeightFog._ClassPtr;
		}

		// Token: 0x060092AF RID: 37551 RVA: 0x000D2614 File Offset: 0x000D0814
		public AExponentialHeightFog() : this(BuiltinUtils.AllocNativeUObject(AExponentialHeightFog.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060092B0 RID: 37552 RVA: 0x000D263C File Offset: 0x000D083C
		[NullableContext(1)]
		public AExponentialHeightFog(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AExponentialHeightFog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700231D RID: 8989
		// (get) Token: 0x060092B1 RID: 37553 RVA: 0x000D266F File Offset: 0x000D086F
		// (set) Token: 0x060092B2 RID: 37554 RVA: 0x000D2683 File Offset: 0x000D0883
		[Nullable(2)]
		public unsafe UExponentialHeightFogComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UExponentialHeightFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AExponentialHeightFog.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AExponentialHeightFog.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x1700231E RID: 8990
		// (get) Token: 0x060092B3 RID: 37555 RVA: 0x000D2698 File Offset: 0x000D0898
		// (set) Token: 0x060092B4 RID: 37556 RVA: 0x000D26B1 File Offset: 0x000D08B1
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AExponentialHeightFog.__PropertyOffset_bEnabled) & AExponentialHeightFog.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AExponentialHeightFog.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)AExponentialHeightFog.__PropertyOffset_bEnabled) & ~AExponentialHeightFog.__PropertyMask_bEnabled) | (value ? AExponentialHeightFog.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x060092B5 RID: 37557 RVA: 0x000D26E1 File Offset: 0x000D08E1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void OnRep_bEnabled()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AExponentialHeightFog.__OnRep_bEnabled_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060092B6 RID: 37558 RVA: 0x000D26F6 File Offset: 0x000D08F6
		static AExponentialHeightFog()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ExponentialHeightFog");
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x000D2704 File Offset: 0x000D0904
		protected AExponentialHeightFog(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040052E2 RID: 21218
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ExponentialHeightFog";

		// Token: 0x040052E3 RID: 21219
		private static IntPtr _ClassPtr;

		// Token: 0x040052E4 RID: 21220
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040052E5 RID: 21221
		internal static int __PropertyOffset_Component;

		// Token: 0x040052E6 RID: 21222
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040052E7 RID: 21223
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x040052E8 RID: 21224
		private static IntPtr __OnRep_bEnabled_NativeFunctionPtr;
	}
}
