using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DB RID: 1243
	[UnrealObjectPath("/Script/ControlRig.CRSimLinearSpring")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCRSimLinearSpring : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600429F RID: 17055 RVA: 0x00063807 File Offset: 0x00061A07
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimLinearSpring._ScriptStructPtr != 0) ? FCRSimLinearSpring._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimLinearSpring", ref FCRSimLinearSpring._ScriptStructPtr);
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x060042A0 RID: 17056 RVA: 0x0006382B File Offset: 0x00061A2B
		// (set) Token: 0x060042A1 RID: 17057 RVA: 0x0006383B File Offset: 0x00061A3B
		public unsafe int SubjectA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_SubjectA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_SubjectA) = value;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x060042A2 RID: 17058 RVA: 0x0006384C File Offset: 0x00061A4C
		// (set) Token: 0x060042A3 RID: 17059 RVA: 0x0006385C File Offset: 0x00061A5C
		public unsafe int SubjectB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_SubjectB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_SubjectB) = value;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x060042A4 RID: 17060 RVA: 0x0006386D File Offset: 0x00061A6D
		// (set) Token: 0x060042A5 RID: 17061 RVA: 0x0006387D File Offset: 0x00061A7D
		public unsafe float Coefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_Coefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_Coefficient) = value;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x060042A6 RID: 17062 RVA: 0x0006388E File Offset: 0x00061A8E
		// (set) Token: 0x060042A7 RID: 17063 RVA: 0x0006389E File Offset: 0x00061A9E
		public unsafe float Equilibrium
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_Equilibrium);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimLinearSpring.__PropertyOffset_Equilibrium) = value;
			}
		}

		// Token: 0x060042A8 RID: 17064 RVA: 0x000638AF File Offset: 0x00061AAF
		public FCRSimLinearSpring()
		{
		}

		// Token: 0x060042A9 RID: 17065 RVA: 0x000638B7 File Offset: 0x00061AB7
		public FCRSimLinearSpring(int SubjectA, int SubjectB, float Coefficient, float Equilibrium)
		{
			this.SubjectA = SubjectA;
			this.SubjectB = SubjectB;
			this.Coefficient = Coefficient;
			this.Equilibrium = Equilibrium;
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x000638DC File Offset: 0x00061ADC
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimLinearSpring.StaticStruct();
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x000638E8 File Offset: 0x00061AE8
		[NullableContext(2)]
		public FCRSimLinearSpring(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x000638F2 File Offset: 0x00061AF2
		public FCRSimLinearSpring(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x000638FD File Offset: 0x00061AFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimLinearSpring(Pointer, false, true);
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00063907 File Offset: 0x00061B07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimLinearSpring(Pointer, MemoryOwner);
		}

		// Token: 0x04001FA7 RID: 8103
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimLinearSpring";

		// Token: 0x04001FA8 RID: 8104
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FA9 RID: 8105
		internal static int __PropertyOffset_SubjectA;

		// Token: 0x04001FAA RID: 8106
		internal static int __PropertyOffset_SubjectB;

		// Token: 0x04001FAB RID: 8107
		internal static int __PropertyOffset_Coefficient;

		// Token: 0x04001FAC RID: 8108
		internal static int __PropertyOffset_Equilibrium;
	}
}
