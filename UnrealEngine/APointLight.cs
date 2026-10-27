using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001016 RID: 4118
	[UnrealObjectPath("/Script/Engine.PointLight")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class APointLight : ALight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E11A RID: 57626 RVA: 0x0014AF6D File Offset: 0x0014916D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APointLight._ClassPtr;
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x0014AF7C File Offset: 0x0014917C
		public APointLight() : this(BuiltinUtils.AllocNativeUObject(APointLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x0014AFA4 File Offset: 0x001491A4
		[NullableContext(1)]
		public APointLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APointLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034DB RID: 13531
		// (get) Token: 0x0600E11D RID: 57629 RVA: 0x0014AFD7 File Offset: 0x001491D7
		// (set) Token: 0x0600E11E RID: 57630 RVA: 0x0014AFEB File Offset: 0x001491EB
		[Nullable(2)]
		public unsafe UPointLightComponent PointLightComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APointLight.__PropertyOffset_PointLightComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APointLight.__PropertyOffset_PointLightComponent, value);
			}
		}

		// Token: 0x0600E11F RID: 57631 RVA: 0x0014B000 File Offset: 0x00149200
		public void SetRadius(float NewRadius)
		{
			APointLight.__SetRadius_Internal(base.NativePtr, NewRadius);
		}

		// Token: 0x0600E120 RID: 57632 RVA: 0x0014B00E File Offset: 0x0014920E
		public void SetLightFalloffExponent(float NewLightFalloffExponent)
		{
			APointLight.__SetLightFalloffExponent_Internal(base.NativePtr, NewLightFalloffExponent);
		}

		// Token: 0x0600E121 RID: 57633 RVA: 0x0014B01C File Offset: 0x0014921C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void HaloPointParaUpdate()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, APointLight.__HaloPointParaUpdate_NativeFunctionPtr, null);
		}

		// Token: 0x0600E122 RID: 57634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRadius_Internal(IntPtr @this, float NewRadius);

		// Token: 0x0600E123 RID: 57635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFalloffExponent_Internal(IntPtr @this, float NewLightFalloffExponent);

		// Token: 0x0600E124 RID: 57636 RVA: 0x0014B030 File Offset: 0x00149230
		static APointLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PointLight");
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x0014B03E File Offset: 0x0014923E
		protected APointLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078E6 RID: 30950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PointLight";

		// Token: 0x040078E7 RID: 30951
		private static IntPtr _ClassPtr;

		// Token: 0x040078E8 RID: 30952
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040078E9 RID: 30953
		internal static int __PropertyOffset_PointLightComponent;

		// Token: 0x040078EA RID: 30954
		private static IntPtr __HaloPointParaUpdate_NativeFunctionPtr;
	}
}
