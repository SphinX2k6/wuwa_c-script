using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DD RID: 1245
	[UnrealObjectPath("/Script/ControlRig.CRSimPointConstraint")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FCRSimPointConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060042C3 RID: 17091 RVA: 0x00063A7B File Offset: 0x00061C7B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimPointConstraint._ScriptStructPtr != 0) ? FCRSimPointConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimPointConstraint", ref FCRSimPointConstraint._ScriptStructPtr);
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x00063A9F File Offset: 0x00061C9F
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x00063AAF File Offset: 0x00061CAF
		public unsafe ECRSimConstraintType Type
		{
			get
			{
				return (ECRSimConstraintType)(*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x00063AC0 File Offset: 0x00061CC0
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x00063AD0 File Offset: 0x00061CD0
		public unsafe int SubjectA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_SubjectA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_SubjectA) = value;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x00063AE1 File Offset: 0x00061CE1
		// (set) Token: 0x060042C9 RID: 17097 RVA: 0x00063AF1 File Offset: 0x00061CF1
		public unsafe int SubjectB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_SubjectB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_SubjectB) = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x00063B02 File Offset: 0x00061D02
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x00063B16 File Offset: 0x00061D16
		public unsafe FVector DataA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_DataA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_DataA) = value;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x00063B2B File Offset: 0x00061D2B
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x00063B3F File Offset: 0x00061D3F
		public unsafe FVector DataB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_DataB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointConstraint.__PropertyOffset_DataB) = value;
			}
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00063B54 File Offset: 0x00061D54
		public FCRSimPointConstraint()
		{
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00063B5C File Offset: 0x00061D5C
		public FCRSimPointConstraint(ECRSimConstraintType Type, int SubjectA, int SubjectB, FVector DataA, FVector DataB)
		{
			this.Type = Type;
			this.SubjectA = SubjectA;
			this.SubjectB = SubjectB;
			this.DataA = DataA;
			this.DataB = DataB;
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00063B89 File Offset: 0x00061D89
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimPointConstraint.StaticStruct();
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00063B95 File Offset: 0x00061D95
		[NullableContext(2)]
		public FCRSimPointConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00063B9F File Offset: 0x00061D9F
		public FCRSimPointConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00063BAA File Offset: 0x00061DAA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimPointConstraint(Pointer, false, true);
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00063BB4 File Offset: 0x00061DB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimPointConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04001FB5 RID: 8117
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimPointConstraint";

		// Token: 0x04001FB6 RID: 8118
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FB7 RID: 8119
		internal static int __PropertyOffset_Type;

		// Token: 0x04001FB8 RID: 8120
		internal static int __PropertyOffset_SubjectA;

		// Token: 0x04001FB9 RID: 8121
		internal static int __PropertyOffset_SubjectB;

		// Token: 0x04001FBA RID: 8122
		internal static int __PropertyOffset_DataA;

		// Token: 0x04001FBB RID: 8123
		internal static int __PropertyOffset_DataB;
	}
}
