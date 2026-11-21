using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003FA RID: 1018
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterVector")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroParameterVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063F4 RID: 25588 RVA: 0x0008ED79 File Offset: 0x0008CF79
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterVector._ScriptStructPtr != 0) ? FKuroParameterVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterVector", ref FKuroParameterVector._ScriptStructPtr);
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x060063F5 RID: 25589 RVA: 0x0008ED9D File Offset: 0x0008CF9D
		// (set) Token: 0x060063F6 RID: 25590 RVA: 0x0008EDB1 File Offset: 0x0008CFB1
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x060063F7 RID: 25591 RVA: 0x0008EDC6 File Offset: 0x0008CFC6
		// (set) Token: 0x060063F8 RID: 25592 RVA: 0x0008EDDA File Offset: 0x0008CFDA
		public unsafe FVector Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterVector.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0008EDEF File Offset: 0x0008CFEF
		public FKuroParameterVector()
		{
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0008EDF7 File Offset: 0x0008CFF7
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterVector.StaticStruct();
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0008EE03 File Offset: 0x0008D003
		[NullableContext(2)]
		public FKuroParameterVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0008EE0D File Offset: 0x0008D00D
		public FKuroParameterVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0008EE18 File Offset: 0x0008D018
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterVector(Pointer, false, true);
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x0008EE22 File Offset: 0x0008D022
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002A39 RID: 10809
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterVector";

		// Token: 0x04002A3A RID: 10810
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A3B RID: 10811
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A3C RID: 10812
		internal static int __PropertyOffset_Value;
	}
}
