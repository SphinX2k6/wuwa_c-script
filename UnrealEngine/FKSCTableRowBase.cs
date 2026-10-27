using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001CF7 RID: 7415
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSCTableRowBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKSCTableRowBase : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C88A RID: 116874 RVA: 0x002A2FD0 File Offset: 0x002A11D0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKSCTableRowBase._ScriptStructPtr != 0) ? FKSCTableRowBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSimpleCombat.KSCTableRowBase", ref FKSCTableRowBase._ScriptStructPtr);
		}

		// Token: 0x170072FD RID: 29437
		// (get) Token: 0x0601C88B RID: 116875 RVA: 0x002A2FF4 File Offset: 0x002A11F4
		// (set) Token: 0x0601C88C RID: 116876 RVA: 0x002A3004 File Offset: 0x002A1204
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

		// Token: 0x170072FE RID: 29438
		// (get) Token: 0x0601C88D RID: 116877 RVA: 0x002A3015 File Offset: 0x002A1215
		// (set) Token: 0x0601C88E RID: 116878 RVA: 0x002A3034 File Offset: 0x002A1234
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

		// Token: 0x0601C88F RID: 116879 RVA: 0x002A3059 File Offset: 0x002A1259
		public FKSCTableRowBase()
		{
		}

		// Token: 0x0601C890 RID: 116880 RVA: 0x002A3061 File Offset: 0x002A1261
		public FKSCTableRowBase(int Id, TSoftObjectPtr<UDataAsset> RuntimeDA)
		{
			this.Id = Id;
			this.RuntimeDA = RuntimeDA;
		}

		// Token: 0x0601C891 RID: 116881 RVA: 0x002A3077 File Offset: 0x002A1277
		protected override IntPtr GetUStructPtr()
		{
			return FKSCTableRowBase.StaticStruct();
		}

		// Token: 0x0601C892 RID: 116882 RVA: 0x002A3083 File Offset: 0x002A1283
		[NullableContext(2)]
		public FKSCTableRowBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C893 RID: 116883 RVA: 0x002A308D File Offset: 0x002A128D
		public FKSCTableRowBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C894 RID: 116884 RVA: 0x002A3098 File Offset: 0x002A1298
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKSCTableRowBase(Pointer, false, true);
		}

		// Token: 0x0601C895 RID: 116885 RVA: 0x002A30A2 File Offset: 0x002A12A2
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKSCTableRowBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400F782 RID: 63362
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSCTableRowBase";

		// Token: 0x0400F783 RID: 63363
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F784 RID: 63364
		internal static int __PropertyOffset_Id;

		// Token: 0x0400F785 RID: 63365
		internal static int __PropertyOffset_RuntimeDA;
	}
}
