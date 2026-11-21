using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200055E RID: 1374
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCTableRowBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCTableRowBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D67 RID: 32103 RVA: 0x000BA055 File Offset: 0x000B8255
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCTableRowBase._ScriptStructPtr != 0) ? FKSCTableRowBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCTableRowBase", ref FKSCTableRowBase._ScriptStructPtr);
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x000BA079 File Offset: 0x000B8279
		// (set) Token: 0x06007D69 RID: 32105 RVA: 0x000BA089 File Offset: 0x000B8289
		public unsafe int Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKSCTableRowBase.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKSCTableRowBase.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x000BA09A File Offset: 0x000B829A
		// (set) Token: 0x06007D6B RID: 32107 RVA: 0x000BA0B9 File Offset: 0x000B82B9
		public TSoftObjectPtr<UDataAsset> RuntimeDA
		{
			get
			{
				return new TSoftObjectPtr<UDataAsset>(base.NativePtr + (IntPtr)FKSCTableRowBase.__PropertyOffset_RuntimeDA, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKSCTableRowBase.__PropertyOffset_RuntimeDA, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x000BA0DE File Offset: 0x000B82DE
		public FKSCTableRowBase()
		{
		}

		// Token: 0x06007D6D RID: 32109 RVA: 0x000BA0E6 File Offset: 0x000B82E6
		protected override IntPtr GetUStructPtr()
		{
			return FKSCTableRowBase.StaticStruct();
		}

		// Token: 0x06007D6E RID: 32110 RVA: 0x000BA0F2 File Offset: 0x000B82F2
		[NullableContext(2)]
		public FKSCTableRowBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D6F RID: 32111 RVA: 0x000BA0FC File Offset: 0x000B82FC
		public FKSCTableRowBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D70 RID: 32112 RVA: 0x000BA107 File Offset: 0x000B8307
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCTableRowBase(Pointer, false, true);
		}

		// Token: 0x06007D71 RID: 32113 RVA: 0x000BA111 File Offset: 0x000B8311
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCTableRowBase(Pointer, MemoryOwner);
		}

		// Token: 0x040036A8 RID: 13992
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCTableRowBase";

		// Token: 0x040036A9 RID: 13993
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036AA RID: 13994
		internal static int __PropertyOffset_Id;

		// Token: 0x040036AB RID: 13995
		internal static int __PropertyOffset_RuntimeDA;
	}
}
