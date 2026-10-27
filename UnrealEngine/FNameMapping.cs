using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ECC RID: 3788
	[UnrealObjectPath("/Script/Engine.NameMapping")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNameMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CD02 RID: 52482 RVA: 0x0012A8E4 File Offset: 0x00128AE4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNameMapping._ScriptStructPtr != 0) ? FNameMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NameMapping", ref FNameMapping._ScriptStructPtr);
		}

		// Token: 0x1700302B RID: 12331
		// (get) Token: 0x0600CD03 RID: 52483 RVA: 0x0012A908 File Offset: 0x00128B08
		// (set) Token: 0x0600CD04 RID: 52484 RVA: 0x0012A91C File Offset: 0x00128B1C
		public unsafe FName NodeName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNameMapping.__PropertyOffset_NodeName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNameMapping.__PropertyOffset_NodeName) = value;
			}
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x0012A931 File Offset: 0x00128B31
		// (set) Token: 0x0600CD06 RID: 52486 RVA: 0x0012A945 File Offset: 0x00128B45
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNameMapping.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNameMapping.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x0600CD07 RID: 52487 RVA: 0x0012A95A File Offset: 0x00128B5A
		public FNameMapping()
		{
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x0012A962 File Offset: 0x00128B62
		public FNameMapping(FName NodeName, FName BoneName)
		{
			this.NodeName = NodeName;
			this.BoneName = BoneName;
		}

		// Token: 0x0600CD09 RID: 52489 RVA: 0x0012A978 File Offset: 0x00128B78
		protected override IntPtr GetUStructPtr()
		{
			return FNameMapping.StaticStruct();
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x0012A984 File Offset: 0x00128B84
		[NullableContext(2)]
		public FNameMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CD0B RID: 52491 RVA: 0x0012A98E File Offset: 0x00128B8E
		public FNameMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x0012A999 File Offset: 0x00128B99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNameMapping(Pointer, false, true);
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x0012A9A3 File Offset: 0x00128BA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNameMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04006E51 RID: 28241
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NameMapping";

		// Token: 0x04006E52 RID: 28242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E53 RID: 28243
		internal static int __PropertyOffset_NodeName;

		// Token: 0x04006E54 RID: 28244
		internal static int __PropertyOffset_BoneName;
	}
}
