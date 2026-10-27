using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DED RID: 3565
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLightmassReplace")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionLightmassReplace : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0D9 RID: 49369 RVA: 0x00115596 File Offset: 0x00113796
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLightmassReplace._ClassPtr;
		}

		// Token: 0x0600C0DA RID: 49370 RVA: 0x001155A4 File Offset: 0x001137A4
		public UMaterialExpressionLightmassReplace() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightmassReplace.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x001155CC File Offset: 0x001137CC
		public UMaterialExpressionLightmassReplace(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightmassReplace.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x00115600 File Offset: 0x00113800
		// (set) Token: 0x0600C0DD RID: 49373 RVA: 0x00115639 File Offset: 0x00113839
		public FExpressionInput Realtime
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Realtime) == null)
				{
					result = (this._Realtime = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLightmassReplace.__PropertyOffset_Realtime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLightmassReplace.__PropertyOffset_Realtime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x0011565C File Offset: 0x0011385C
		// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x00115695 File Offset: 0x00113895
		public FExpressionInput Lightmass
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Lightmass) == null)
				{
					result = (this._Lightmass = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionLightmassReplace.__PropertyOffset_Lightmass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionLightmassReplace.__PropertyOffset_Lightmass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x001156B6 File Offset: 0x001138B6
		static UMaterialExpressionLightmassReplace()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLightmassReplace");
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x001156C4 File Offset: 0x001138C4
		protected UMaterialExpressionLightmassReplace(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006661 RID: 26209
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLightmassReplace";

		// Token: 0x04006662 RID: 26210
		private static IntPtr _ClassPtr;

		// Token: 0x04006663 RID: 26211
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006664 RID: 26212
		internal static int __PropertyOffset_Realtime;

		// Token: 0x04006665 RID: 26213
		[Nullable(2)]
		private FExpressionInput _Realtime;

		// Token: 0x04006666 RID: 26214
		internal static int __PropertyOffset_Lightmass;

		// Token: 0x04006667 RID: 26215
		[Nullable(2)]
		private FExpressionInput _Lightmass;
	}
}
