using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBB RID: 3515
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDivide")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionDivide : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEE3 RID: 48867 RVA: 0x001118ED File Offset: 0x0010FAED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDivide._ClassPtr;
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x001118FC File Offset: 0x0010FAFC
		public UMaterialExpressionDivide() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDivide.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEE5 RID: 48869 RVA: 0x00111924 File Offset: 0x0010FB24
		public UMaterialExpressionDivide(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDivide.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x0600BEE6 RID: 48870 RVA: 0x00111958 File Offset: 0x0010FB58
		// (set) Token: 0x0600BEE7 RID: 48871 RVA: 0x00111991 File Offset: 0x0010FB91
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x0600BEE8 RID: 48872 RVA: 0x001119B4 File Offset: 0x0010FBB4
		// (set) Token: 0x0600BEE9 RID: 48873 RVA: 0x001119ED File Offset: 0x0010FBED
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x0600BEEA RID: 48874 RVA: 0x00111A0E File Offset: 0x0010FC0E
		// (set) Token: 0x0600BEEB RID: 48875 RVA: 0x00111A1E File Offset: 0x0010FC1E
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x0600BEEC RID: 48876 RVA: 0x00111A2F File Offset: 0x0010FC2F
		// (set) Token: 0x0600BEED RID: 48877 RVA: 0x00111A3F File Offset: 0x0010FC3F
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionDivide.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600BEEE RID: 48878 RVA: 0x00111A50 File Offset: 0x0010FC50
		static UMaterialExpressionDivide()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDivide");
		}

		// Token: 0x0600BEEF RID: 48879 RVA: 0x00111A5E File Offset: 0x0010FC5E
		protected UMaterialExpressionDivide(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064F9 RID: 25849
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDivide";

		// Token: 0x040064FA RID: 25850
		private static IntPtr _ClassPtr;

		// Token: 0x040064FB RID: 25851
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064FC RID: 25852
		internal static int __PropertyOffset_A;

		// Token: 0x040064FD RID: 25853
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040064FE RID: 25854
		internal static int __PropertyOffset_B;

		// Token: 0x040064FF RID: 25855
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x04006500 RID: 25856
		internal static int __PropertyOffset_ConstA;

		// Token: 0x04006501 RID: 25857
		internal static int __PropertyOffset_ConstB;
	}
}
