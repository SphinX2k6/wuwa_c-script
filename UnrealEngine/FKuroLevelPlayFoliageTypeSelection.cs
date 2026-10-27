using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018EB RID: 6379
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayFoliageTypeSelection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroLevelPlayFoliageTypeSelection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017A87 RID: 96903 RVA: 0x0022AC86 File Offset: 0x00228E86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlayFoliageTypeSelection._ScriptStructPtr != 0) ? FKuroLevelPlayFoliageTypeSelection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlayFoliageTypeSelection", ref FKuroLevelPlayFoliageTypeSelection._ScriptStructPtr);
		}

		// Token: 0x17005F5A RID: 24410
		// (get) Token: 0x06017A88 RID: 96904 RVA: 0x0022ACAA File Offset: 0x00228EAA
		// (set) Token: 0x06017A89 RID: 96905 RVA: 0x0022ACBE File Offset: 0x00228EBE
		public unsafe string FoliageTypePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroLevelPlayFoliageTypeSelection.__PropertyOffset_FoliageTypePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroLevelPlayFoliageTypeSelection.__PropertyOffset_FoliageTypePath)), value);
			}
		}

		// Token: 0x06017A8A RID: 96906 RVA: 0x0022ACD3 File Offset: 0x00228ED3
		public FKuroLevelPlayFoliageTypeSelection()
		{
		}

		// Token: 0x06017A8B RID: 96907 RVA: 0x0022ACDB File Offset: 0x00228EDB
		public FKuroLevelPlayFoliageTypeSelection(string FoliageTypePath)
		{
			this.FoliageTypePath = FoliageTypePath;
		}

		// Token: 0x06017A8C RID: 96908 RVA: 0x0022ACEA File Offset: 0x00228EEA
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlayFoliageTypeSelection.StaticStruct();
		}

		// Token: 0x06017A8D RID: 96909 RVA: 0x0022ACF6 File Offset: 0x00228EF6
		[NullableContext(2)]
		public FKuroLevelPlayFoliageTypeSelection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017A8E RID: 96910 RVA: 0x0022AD00 File Offset: 0x00228F00
		public FKuroLevelPlayFoliageTypeSelection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017A8F RID: 96911 RVA: 0x0022AD0B File Offset: 0x00228F0B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlayFoliageTypeSelection(Pointer, false, true);
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x0022AD15 File Offset: 0x00228F15
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlayFoliageTypeSelection(Pointer, MemoryOwner);
		}

		// Token: 0x0400CD9E RID: 52638
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayFoliageTypeSelection";

		// Token: 0x0400CD9F RID: 52639
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CDA0 RID: 52640
		internal static int __PropertyOffset_FoliageTypePath;
	}
}
