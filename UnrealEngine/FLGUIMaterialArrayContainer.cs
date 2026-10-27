using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002088 RID: 8328
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIMaterialArrayContainer")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLGUIMaterialArrayContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F6CA RID: 128714 RVA: 0x002EACCF File Offset: 0x002E8ECF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLGUIMaterialArrayContainer._ScriptStructPtr != 0) ? FLGUIMaterialArrayContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.LGUIMaterialArrayContainer", ref FLGUIMaterialArrayContainer._ScriptStructPtr);
		}

		// Token: 0x17007C0B RID: 31755
		// (get) Token: 0x0601F6CB RID: 128715 RVA: 0x002EACF4 File Offset: 0x002E8EF4
		// (set) Token: 0x0601F6CC RID: 128716 RVA: 0x002EAD37 File Offset: 0x002E8F37
		public TArray<UMaterialInstanceDynamic> MaterialList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._MaterialList) == null)
				{
					result = (this._MaterialList = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)FLGUIMaterialArrayContainer.__PropertyOffset_MaterialList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialList.CopyAssign(value);
			}
		}

		// Token: 0x0601F6CD RID: 128717 RVA: 0x002EAD45 File Offset: 0x002E8F45
		public FLGUIMaterialArrayContainer()
		{
		}

		// Token: 0x0601F6CE RID: 128718 RVA: 0x002EAD4D File Offset: 0x002E8F4D
		public FLGUIMaterialArrayContainer(TArray<UMaterialInstanceDynamic> MaterialList)
		{
			this.MaterialList = MaterialList;
		}

		// Token: 0x0601F6CF RID: 128719 RVA: 0x002EAD5C File Offset: 0x002E8F5C
		protected override IntPtr GetUStructPtr()
		{
			return FLGUIMaterialArrayContainer.StaticStruct();
		}

		// Token: 0x0601F6D0 RID: 128720 RVA: 0x002EAD68 File Offset: 0x002E8F68
		[NullableContext(2)]
		public FLGUIMaterialArrayContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F6D1 RID: 128721 RVA: 0x002EAD72 File Offset: 0x002E8F72
		public FLGUIMaterialArrayContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F6D2 RID: 128722 RVA: 0x002EAD7D File Offset: 0x002E8F7D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLGUIMaterialArrayContainer(Pointer, false, true);
		}

		// Token: 0x0601F6D3 RID: 128723 RVA: 0x002EAD87 File Offset: 0x002E8F87
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLGUIMaterialArrayContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04010F91 RID: 69521
		public const string __ObjectPath = "/Script/LGUI.LGUIMaterialArrayContainer";

		// Token: 0x04010F92 RID: 69522
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F93 RID: 69523
		internal static int __PropertyOffset_MaterialList;

		// Token: 0x04010F94 RID: 69524
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _MaterialList;
	}
}
