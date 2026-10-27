using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E48 RID: 3656
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionSkyAtmosphereLightIlluminance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C430 RID: 50224 RVA: 0x0011B9DB File Offset: 0x00119BDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereLightIlluminance._ClassPtr;
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x0011B9E8 File Offset: 0x00119BE8
		public UMaterialExpressionSkyAtmosphereLightIlluminance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightIlluminance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C432 RID: 50226 RVA: 0x0011BA10 File Offset: 0x00119C10
		public UMaterialExpressionSkyAtmosphereLightIlluminance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereLightIlluminance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600C433 RID: 50227 RVA: 0x0011BA43 File Offset: 0x00119C43
		// (set) Token: 0x0600C434 RID: 50228 RVA: 0x0011BA53 File Offset: 0x00119C53
		public unsafe int LightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightIlluminance.__PropertyOffset_LightIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightIlluminance.__PropertyOffset_LightIndex) = value;
			}
		}

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600C435 RID: 50229 RVA: 0x0011BA64 File Offset: 0x00119C64
		// (set) Token: 0x0600C436 RID: 50230 RVA: 0x0011BA9D File Offset: 0x00119C9D
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightIlluminance.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSkyAtmosphereLightIlluminance.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C437 RID: 50231 RVA: 0x0011BABE File Offset: 0x00119CBE
		static UMaterialExpressionSkyAtmosphereLightIlluminance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance");
		}

		// Token: 0x0600C438 RID: 50232 RVA: 0x0011BACC File Offset: 0x00119CCC
		protected UMaterialExpressionSkyAtmosphereLightIlluminance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068BB RID: 26811
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereLightIlluminance";

		// Token: 0x040068BC RID: 26812
		private static IntPtr _ClassPtr;

		// Token: 0x040068BD RID: 26813
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068BE RID: 26814
		internal static int __PropertyOffset_LightIndex;

		// Token: 0x040068BF RID: 26815
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x040068C0 RID: 26816
		[Nullable(2)]
		private FExpressionInput _WorldPosition;
	}
}
