using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002BB RID: 699
	[UnrealObjectPath("/Script/AnimationCore.ConstraintDescriptor")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FConstraintDescriptor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026F0 RID: 9968 RVA: 0x0003A88F File Offset: 0x00038A8F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintDescriptor._ScriptStructPtr != 0) ? FConstraintDescriptor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.ConstraintDescriptor", ref FConstraintDescriptor._ScriptStructPtr);
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x0003A8B3 File Offset: 0x00038AB3
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x0003A8C3 File Offset: 0x00038AC3
		public unsafe EConstraintType Type
		{
			get
			{
				return (EConstraintType)(*(base.NativePtr + (IntPtr)FConstraintDescriptor.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDescriptor.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0003A8D4 File Offset: 0x00038AD4
		public FConstraintDescriptor()
		{
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0003A8DC File Offset: 0x00038ADC
		public FConstraintDescriptor(EConstraintType Type)
		{
			this.Type = Type;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0003A8EB File Offset: 0x00038AEB
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintDescriptor.StaticStruct();
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x0003A8F7 File Offset: 0x00038AF7
		[NullableContext(2)]
		public FConstraintDescriptor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x0003A901 File Offset: 0x00038B01
		public FConstraintDescriptor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0003A90C File Offset: 0x00038B0C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintDescriptor(Pointer, false, true);
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x0003A916 File Offset: 0x00038B16
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintDescriptor(Pointer, MemoryOwner);
		}

		// Token: 0x04000F50 RID: 3920
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.ConstraintDescriptor";

		// Token: 0x04000F51 RID: 3921
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F52 RID: 3922
		internal static int __PropertyOffset_Type;
	}
}
