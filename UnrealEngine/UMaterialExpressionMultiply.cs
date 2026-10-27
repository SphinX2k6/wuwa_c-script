using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFA RID: 3578
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMultiply")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionMultiply : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C18A RID: 49546 RVA: 0x00116D0B File Offset: 0x00114F0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMultiply._ClassPtr;
		}

		// Token: 0x0600C18B RID: 49547 RVA: 0x00116D18 File Offset: 0x00114F18
		public UMaterialExpressionMultiply() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMultiply.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C18C RID: 49548 RVA: 0x00116D40 File Offset: 0x00114F40
		public UMaterialExpressionMultiply(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMultiply.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CF6 RID: 11510
		// (get) Token: 0x0600C18D RID: 49549 RVA: 0x00116D74 File Offset: 0x00114F74
		// (set) Token: 0x0600C18E RID: 49550 RVA: 0x00116DAD File Offset: 0x00114FAD
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF7 RID: 11511
		// (get) Token: 0x0600C18F RID: 49551 RVA: 0x00116DD0 File Offset: 0x00114FD0
		// (set) Token: 0x0600C190 RID: 49552 RVA: 0x00116E09 File Offset: 0x00115009
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF8 RID: 11512
		// (get) Token: 0x0600C191 RID: 49553 RVA: 0x00116E2A File Offset: 0x0011502A
		// (set) Token: 0x0600C192 RID: 49554 RVA: 0x00116E3A File Offset: 0x0011503A
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002CF9 RID: 11513
		// (get) Token: 0x0600C193 RID: 49555 RVA: 0x00116E4B File Offset: 0x0011504B
		// (set) Token: 0x0600C194 RID: 49556 RVA: 0x00116E5B File Offset: 0x0011505B
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMultiply.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x00116E6C File Offset: 0x0011506C
		static UMaterialExpressionMultiply()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMultiply");
		}

		// Token: 0x0600C196 RID: 49558 RVA: 0x00116E7A File Offset: 0x0011507A
		protected UMaterialExpressionMultiply(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066EB RID: 26347
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMultiply";

		// Token: 0x040066EC RID: 26348
		private static IntPtr _ClassPtr;

		// Token: 0x040066ED RID: 26349
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066EE RID: 26350
		internal static int __PropertyOffset_A;

		// Token: 0x040066EF RID: 26351
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040066F0 RID: 26352
		internal static int __PropertyOffset_B;

		// Token: 0x040066F1 RID: 26353
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040066F2 RID: 26354
		internal static int __PropertyOffset_ConstA;

		// Token: 0x040066F3 RID: 26355
		internal static int __PropertyOffset_ConstB;
	}
}
