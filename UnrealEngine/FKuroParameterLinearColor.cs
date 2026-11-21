using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003F9 RID: 1017
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterLinearColor")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroParameterLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063E9 RID: 25577 RVA: 0x0008ECC7 File Offset: 0x0008CEC7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterLinearColor._ScriptStructPtr != 0) ? FKuroParameterLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterLinearColor", ref FKuroParameterLinearColor._ScriptStructPtr);
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x0008ECEB File Offset: 0x0008CEEB
		// (set) Token: 0x060063EB RID: 25579 RVA: 0x0008ECFF File Offset: 0x0008CEFF
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x0008ED14 File Offset: 0x0008CF14
		// (set) Token: 0x060063ED RID: 25581 RVA: 0x0008ED28 File Offset: 0x0008CF28
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterLinearColor.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x0008ED3D File Offset: 0x0008CF3D
		public FKuroParameterLinearColor()
		{
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x0008ED45 File Offset: 0x0008CF45
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterLinearColor.StaticStruct();
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0008ED51 File Offset: 0x0008CF51
		[NullableContext(2)]
		public FKuroParameterLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0008ED5B File Offset: 0x0008CF5B
		public FKuroParameterLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0008ED66 File Offset: 0x0008CF66
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterLinearColor(Pointer, false, true);
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x0008ED70 File Offset: 0x0008CF70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x04002A35 RID: 10805
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterLinearColor";

		// Token: 0x04002A36 RID: 10806
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A37 RID: 10807
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A38 RID: 10808
		internal static int __PropertyOffset_Value;
	}
}
