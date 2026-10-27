using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200018A RID: 394
	[UnrealObjectPath("/Script/AIModule.EnvNamedValue")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FEnvNamedValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060018A3 RID: 6307 RVA: 0x000243EB File Offset: 0x000225EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEnvNamedValue._ScriptStructPtr != 0) ? FEnvNamedValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.EnvNamedValue", ref FEnvNamedValue._ScriptStructPtr);
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0002440F File Offset: 0x0002260F
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x00024423 File Offset: 0x00022623
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x00024438 File Offset: 0x00022638
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x00024448 File Offset: 0x00022648
		public unsafe EAIParamType ParamType
		{
			get
			{
				return (EAIParamType)(*(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_ParamType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_ParamType) = (byte)value;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x00024459 File Offset: 0x00022659
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00024469 File Offset: 0x00022669
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEnvNamedValue.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0002447A File Offset: 0x0002267A
		public FEnvNamedValue()
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00024482 File Offset: 0x00022682
		public FEnvNamedValue(FName ParamName, EAIParamType ParamType, float Value)
		{
			this.ParamName = ParamName;
			this.ParamType = ParamType;
			this.Value = Value;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0002449F File Offset: 0x0002269F
		protected override IntPtr GetUStructPtr()
		{
			return FEnvNamedValue.StaticStruct();
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000244AB File Offset: 0x000226AB
		[NullableContext(2)]
		public FEnvNamedValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000244B5 File Offset: 0x000226B5
		public FEnvNamedValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000244C0 File Offset: 0x000226C0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEnvNamedValue(Pointer, false, true);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000244CA File Offset: 0x000226CA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEnvNamedValue(Pointer, MemoryOwner);
		}

		// Token: 0x040006DD RID: 1757
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvNamedValue";

		// Token: 0x040006DE RID: 1758
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040006DF RID: 1759
		internal static int __PropertyOffset_ParamName;

		// Token: 0x040006E0 RID: 1760
		internal static int __PropertyOffset_ParamType;

		// Token: 0x040006E1 RID: 1761
		internal static int __PropertyOffset_Value;
	}
}
