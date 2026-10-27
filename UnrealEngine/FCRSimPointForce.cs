using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DF RID: 1247
	[UnrealObjectPath("/Script/ControlRig.CRSimPointForce")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FCRSimPointForce : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060042E9 RID: 17129 RVA: 0x00063E70 File Offset: 0x00062070
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimPointForce._ScriptStructPtr != 0) ? FCRSimPointForce._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimPointForce", ref FCRSimPointForce._ScriptStructPtr);
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x00063E94 File Offset: 0x00062094
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x00063EA4 File Offset: 0x000620A4
		public unsafe ECRSimPointForceType ForceType
		{
			get
			{
				return (ECRSimPointForceType)(*(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_ForceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_ForceType) = (byte)value;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x00063EB5 File Offset: 0x000620B5
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x00063EC9 File Offset: 0x000620C9
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x00063EDE File Offset: 0x000620DE
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x00063EEE File Offset: 0x000620EE
		public unsafe float Coefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_Coefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_Coefficient) = value;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x00063EFF File Offset: 0x000620FF
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x00063F0F File Offset: 0x0006210F
		public unsafe bool bNormalize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_bNormalize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPointForce.__PropertyOffset_bNormalize) = (value ? 1 : 0);
			}
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00063F20 File Offset: 0x00062120
		public FCRSimPointForce()
		{
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00063F28 File Offset: 0x00062128
		public FCRSimPointForce(ECRSimPointForceType ForceType, FVector Vector, float Coefficient, bool bNormalize)
		{
			this.ForceType = ForceType;
			this.Vector = Vector;
			this.Coefficient = Coefficient;
			this.bNormalize = bNormalize;
		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00063F4D File Offset: 0x0006214D
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimPointForce.StaticStruct();
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00063F59 File Offset: 0x00062159
		[NullableContext(2)]
		public FCRSimPointForce(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00063F63 File Offset: 0x00062163
		public FCRSimPointForce(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00063F6E File Offset: 0x0006216E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimPointForce(Pointer, false, true);
		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00063F78 File Offset: 0x00062178
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimPointForce(Pointer, MemoryOwner);
		}

		// Token: 0x04001FCA RID: 8138
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimPointForce";

		// Token: 0x04001FCB RID: 8139
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FCC RID: 8140
		internal static int __PropertyOffset_ForceType;

		// Token: 0x04001FCD RID: 8141
		internal static int __PropertyOffset_Vector;

		// Token: 0x04001FCE RID: 8142
		internal static int __PropertyOffset_Coefficient;

		// Token: 0x04001FCF RID: 8143
		internal static int __PropertyOffset_bNormalize;
	}
}
