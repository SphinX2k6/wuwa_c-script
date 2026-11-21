using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003F8 RID: 1016
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterFloat")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroParameterFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063DE RID: 25566 RVA: 0x0008EC1D File Offset: 0x0008CE1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterFloat._ScriptStructPtr != 0) ? FKuroParameterFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterFloat", ref FKuroParameterFloat._ScriptStructPtr);
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x060063DF RID: 25567 RVA: 0x0008EC41 File Offset: 0x0008CE41
		// (set) Token: 0x060063E0 RID: 25568 RVA: 0x0008EC55 File Offset: 0x0008CE55
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x060063E1 RID: 25569 RVA: 0x0008EC6A File Offset: 0x0008CE6A
		// (set) Token: 0x060063E2 RID: 25570 RVA: 0x0008EC7A File Offset: 0x0008CE7A
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x0008EC8B File Offset: 0x0008CE8B
		public FKuroParameterFloat()
		{
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x0008EC93 File Offset: 0x0008CE93
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterFloat.StaticStruct();
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0008EC9F File Offset: 0x0008CE9F
		[NullableContext(2)]
		public FKuroParameterFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x0008ECA9 File Offset: 0x0008CEA9
		public FKuroParameterFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x0008ECB4 File Offset: 0x0008CEB4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterFloat(Pointer, false, true);
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x0008ECBE File Offset: 0x0008CEBE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04002A31 RID: 10801
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterFloat";

		// Token: 0x04002A32 RID: 10802
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A33 RID: 10803
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A34 RID: 10804
		internal static int __PropertyOffset_Value;
	}
}
