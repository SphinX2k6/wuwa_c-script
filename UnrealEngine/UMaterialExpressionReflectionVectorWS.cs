using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E27 RID: 3623
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionReflectionVectorWS")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionReflectionVectorWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2DE RID: 49886 RVA: 0x00119201 File Offset: 0x00117401
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionReflectionVectorWS._ClassPtr;
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x00119210 File Offset: 0x00117410
		public UMaterialExpressionReflectionVectorWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflectionVectorWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x00119238 File Offset: 0x00117438
		public UMaterialExpressionReflectionVectorWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflectionVectorWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600C2E1 RID: 49889 RVA: 0x0011926C File Offset: 0x0011746C
		// (set) Token: 0x0600C2E2 RID: 49890 RVA: 0x001192A5 File Offset: 0x001174A5
		public FExpressionInput CustomWorldNormal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._CustomWorldNormal) == null)
				{
					result = (this._CustomWorldNormal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReflectionVectorWS.__PropertyOffset_CustomWorldNormal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReflectionVectorWS.__PropertyOffset_CustomWorldNormal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x0600C2E3 RID: 49891 RVA: 0x001192C6 File Offset: 0x001174C6
		// (set) Token: 0x0600C2E4 RID: 49892 RVA: 0x001192DF File Offset: 0x001174DF
		public unsafe bool bNormalizeCustomWorldNormal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionReflectionVectorWS.__PropertyOffset_bNormalizeCustomWorldNormal) & UMaterialExpressionReflectionVectorWS.__PropertyMask_bNormalizeCustomWorldNormal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionReflectionVectorWS.__PropertyOffset_bNormalizeCustomWorldNormal) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionReflectionVectorWS.__PropertyOffset_bNormalizeCustomWorldNormal) & ~UMaterialExpressionReflectionVectorWS.__PropertyMask_bNormalizeCustomWorldNormal) | (value ? UMaterialExpressionReflectionVectorWS.__PropertyMask_bNormalizeCustomWorldNormal : 0));
			}
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x0011930F File Offset: 0x0011750F
		static UMaterialExpressionReflectionVectorWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionReflectionVectorWS");
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x0011931D File Offset: 0x0011751D
		protected UMaterialExpressionReflectionVectorWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067CC RID: 26572
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionReflectionVectorWS";

		// Token: 0x040067CD RID: 26573
		private static IntPtr _ClassPtr;

		// Token: 0x040067CE RID: 26574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067CF RID: 26575
		internal static int __PropertyOffset_CustomWorldNormal;

		// Token: 0x040067D0 RID: 26576
		[Nullable(2)]
		private FExpressionInput _CustomWorldNormal;

		// Token: 0x040067D1 RID: 26577
		internal static int __PropertyOffset_bNormalizeCustomWorldNormal;

		// Token: 0x040067D2 RID: 26578
		internal static byte __PropertyMask_bNormalizeCustomWorldNormal;
	}
}
