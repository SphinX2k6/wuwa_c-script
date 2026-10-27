using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC0 RID: 3520
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionEqualCondition")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMaterialExpressionEqualCondition : UMaterialExpressionBranchCondition, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF0E RID: 48910 RVA: 0x00111DAE File Offset: 0x0010FFAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionEqualCondition._ClassPtr;
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x00111DBC File Offset: 0x0010FFBC
		public UMaterialExpressionEqualCondition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionEqualCondition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x00111DE4 File Offset: 0x0010FFE4
		public UMaterialExpressionEqualCondition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionEqualCondition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C49 RID: 11337
		// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x00111E18 File Offset: 0x00110018
		// (set) Token: 0x0600BF12 RID: 48914 RVA: 0x00111E51 File Offset: 0x00110051
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C4A RID: 11338
		// (get) Token: 0x0600BF13 RID: 48915 RVA: 0x00111E74 File Offset: 0x00110074
		// (set) Token: 0x0600BF14 RID: 48916 RVA: 0x00111EAD File Offset: 0x001100AD
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C4B RID: 11339
		// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x00111ECE File Offset: 0x001100CE
		// (set) Token: 0x0600BF16 RID: 48918 RVA: 0x00111EDE File Offset: 0x001100DE
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x17002C4C RID: 11340
		// (get) Token: 0x0600BF17 RID: 48919 RVA: 0x00111EEF File Offset: 0x001100EF
		// (set) Token: 0x0600BF18 RID: 48920 RVA: 0x00111EFF File Offset: 0x001100FF
		public unsafe float EqualsThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_EqualsThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionEqualCondition.__PropertyOffset_EqualsThreshold) = value;
			}
		}

		// Token: 0x0600BF19 RID: 48921 RVA: 0x00111F10 File Offset: 0x00110110
		static UMaterialExpressionEqualCondition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionEqualCondition");
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x00111F1E File Offset: 0x0011011E
		protected UMaterialExpressionEqualCondition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006516 RID: 25878
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionEqualCondition";

		// Token: 0x04006517 RID: 25879
		private static IntPtr _ClassPtr;

		// Token: 0x04006518 RID: 25880
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006519 RID: 25881
		internal static int __PropertyOffset_A;

		// Token: 0x0400651A RID: 25882
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x0400651B RID: 25883
		internal static int __PropertyOffset_B;

		// Token: 0x0400651C RID: 25884
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x0400651D RID: 25885
		internal static int __PropertyOffset_ConstB;

		// Token: 0x0400651E RID: 25886
		internal static int __PropertyOffset_EqualsThreshold;
	}
}
