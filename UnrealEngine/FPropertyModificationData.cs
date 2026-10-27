using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002658 RID: 9816
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PrefabSystem.PropertyModificationData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPropertyModificationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060247B0 RID: 149424 RVA: 0x0036009E File Offset: 0x0035E29E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPropertyModificationData._ScriptStructPtr != 0) ? FPropertyModificationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PrefabSystem.PropertyModificationData", ref FPropertyModificationData._ScriptStructPtr);
		}

		// Token: 0x17008CA2 RID: 36002
		// (get) Token: 0x060247B1 RID: 149425 RVA: 0x003600C2 File Offset: 0x0035E2C2
		// (set) Token: 0x060247B2 RID: 149426 RVA: 0x003600D2 File Offset: 0x0035E2D2
		public unsafe int TargetFileID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPropertyModificationData.__PropertyOffset_TargetFileID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPropertyModificationData.__PropertyOffset_TargetFileID) = value;
			}
		}

		// Token: 0x17008CA3 RID: 36003
		// (get) Token: 0x060247B3 RID: 149427 RVA: 0x003600E4 File Offset: 0x0035E2E4
		// (set) Token: 0x060247B4 RID: 149428 RVA: 0x00360127 File Offset: 0x0035E327
		public TArray<FName> PropertyFNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._PropertyFNames) == null)
				{
					result = (this._PropertyFNames = new TArray<FName>(base.NativePtr + (IntPtr)FPropertyModificationData.__PropertyOffset_PropertyFNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyFNames.CopyAssign(value);
			}
		}

		// Token: 0x17008CA4 RID: 36004
		// (get) Token: 0x060247B5 RID: 149429 RVA: 0x00360138 File Offset: 0x0035E338
		// (set) Token: 0x060247B6 RID: 149430 RVA: 0x0036017B File Offset: 0x0035E37B
		public TArray<byte> PropertyData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._PropertyData) == null)
				{
					result = (this._PropertyData = new TArray<byte>(base.NativePtr + (IntPtr)FPropertyModificationData.__PropertyOffset_PropertyData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PropertyData.CopyAssign(value);
			}
		}

		// Token: 0x060247B7 RID: 149431 RVA: 0x00360189 File Offset: 0x0035E389
		public FPropertyModificationData()
		{
		}

		// Token: 0x060247B8 RID: 149432 RVA: 0x00360191 File Offset: 0x0035E391
		public FPropertyModificationData(int TargetFileID, TArray<FName> PropertyFNames, TArray<byte> PropertyData, string ActorDisplayName)
		{
			this.TargetFileID = TargetFileID;
			this.PropertyFNames = PropertyFNames;
			this.PropertyData = PropertyData;
		}

		// Token: 0x060247B9 RID: 149433 RVA: 0x003601AE File Offset: 0x0035E3AE
		protected override IntPtr GetUStructPtr()
		{
			return FPropertyModificationData.StaticStruct();
		}

		// Token: 0x060247BA RID: 149434 RVA: 0x003601BA File Offset: 0x0035E3BA
		[NullableContext(2)]
		public FPropertyModificationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060247BB RID: 149435 RVA: 0x003601C4 File Offset: 0x0035E3C4
		public FPropertyModificationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060247BC RID: 149436 RVA: 0x003601CF File Offset: 0x0035E3CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPropertyModificationData(Pointer, false, true);
		}

		// Token: 0x060247BD RID: 149437 RVA: 0x003601D9 File Offset: 0x0035E3D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPropertyModificationData(Pointer, MemoryOwner);
		}

		// Token: 0x04013997 RID: 80279
		public const string __ObjectPath = "/Script/PrefabSystem.PropertyModificationData";

		// Token: 0x04013998 RID: 80280
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013999 RID: 80281
		internal static int __PropertyOffset_TargetFileID;

		// Token: 0x0401399A RID: 80282
		internal static int __PropertyOffset_PropertyFNames;

		// Token: 0x0401399B RID: 80283
		[Nullable(2)]
		private TArray<FName> _PropertyFNames;

		// Token: 0x0401399C RID: 80284
		internal static int __PropertyOffset_PropertyData;

		// Token: 0x0401399D RID: 80285
		[Nullable(2)]
		private TArray<byte> _PropertyData;
	}
}
