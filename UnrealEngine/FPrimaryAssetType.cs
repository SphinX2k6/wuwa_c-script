using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200075D RID: 1885
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.PrimaryAssetType")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FPrimaryAssetType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600636C RID: 25452 RVA: 0x0008EBEB File Offset: 0x0008CDEB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetType._ScriptStructPtr != 0) ? FPrimaryAssetType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PrimaryAssetType", ref FPrimaryAssetType._ScriptStructPtr);
		}

		// Token: 0x170017A9 RID: 6057
		// (get) Token: 0x0600636D RID: 25453 RVA: 0x0008EC0F File Offset: 0x0008CE0F
		// (set) Token: 0x0600636E RID: 25454 RVA: 0x0008EC23 File Offset: 0x0008CE23
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetType.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetType.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x0600636F RID: 25455 RVA: 0x0008EC38 File Offset: 0x0008CE38
		public FPrimaryAssetType()
		{
		}

		// Token: 0x06006370 RID: 25456 RVA: 0x0008EC40 File Offset: 0x0008CE40
		public FPrimaryAssetType(FName Name)
		{
			this.Name = Name;
		}

		// Token: 0x06006371 RID: 25457 RVA: 0x0008EC4F File Offset: 0x0008CE4F
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetType.StaticStruct();
		}

		// Token: 0x06006372 RID: 25458 RVA: 0x0008EC5B File Offset: 0x0008CE5B
		[NullableContext(2)]
		public FPrimaryAssetType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006373 RID: 25459 RVA: 0x0008EC65 File Offset: 0x0008CE65
		public FPrimaryAssetType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006374 RID: 25460 RVA: 0x0008EC70 File Offset: 0x0008CE70
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetType(Pointer, false, true);
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x0008EC7A File Offset: 0x0008CE7A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetType(Pointer, MemoryOwner);
		}

		// Token: 0x04002FA5 RID: 12197
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.PrimaryAssetType";

		// Token: 0x04002FA6 RID: 12198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002FA7 RID: 12199
		internal static int __PropertyOffset_Name;
	}
}
