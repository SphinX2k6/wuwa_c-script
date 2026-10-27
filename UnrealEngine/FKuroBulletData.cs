using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016F2 RID: 5874
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletData")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 704)]
	public class FKuroBulletData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601533F RID: 86847 RVA: 0x001F2A0F File Offset: 0x001F0C0F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBulletData._ScriptStructPtr != 0) ? FKuroBulletData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.KuroBulletData", ref FKuroBulletData._ScriptStructPtr);
		}

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x06015340 RID: 86848 RVA: 0x001F2A33 File Offset: 0x001F0C33
		// (set) Token: 0x06015341 RID: 86849 RVA: 0x001F2A47 File Offset: 0x001F0C47
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x06015342 RID: 86850 RVA: 0x001F2A5C File Offset: 0x001F0C5C
		// (set) Token: 0x06015343 RID: 86851 RVA: 0x001F2A9F File Offset: 0x001F0C9F
		public FKuroBulletDataBase Base
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletDataBase result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FKuroBulletDataBase(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletDataBase.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x06015344 RID: 86852 RVA: 0x001F2AC0 File Offset: 0x001F0CC0
		// (set) Token: 0x06015345 RID: 86853 RVA: 0x001F2B03 File Offset: 0x001F0D03
		public FKuroBulletDataMove Move
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletDataMove result;
				if ((result = this._Move) == null)
				{
					result = (this._Move = new FKuroBulletDataMove(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Move, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletDataMove.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Move, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x06015346 RID: 86854 RVA: 0x001F2B24 File Offset: 0x001F0D24
		// (set) Token: 0x06015347 RID: 86855 RVA: 0x001F2B67 File Offset: 0x001F0D67
		public FKuroBulletDataRender Render
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletDataRender result;
				if ((result = this._Render) == null)
				{
					result = (this._Render = new FKuroBulletDataRender(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Render, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletDataRender.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Render, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x06015348 RID: 86856 RVA: 0x001F2B88 File Offset: 0x001F0D88
		// (set) Token: 0x06015349 RID: 86857 RVA: 0x001F2BCB File Offset: 0x001F0DCB
		public FKuroBulletDataLogic Logic
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletDataLogic result;
				if ((result = this._Logic) == null)
				{
					result = (this._Logic = new FKuroBulletDataLogic(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Logic, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletDataLogic.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Logic, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x0601534A RID: 86858 RVA: 0x001F2BEC File Offset: 0x001F0DEC
		// (set) Token: 0x0601534B RID: 86859 RVA: 0x001F2C2F File Offset: 0x001F0E2F
		public FKuroBulletDataTimeScale TimeScale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroBulletDataTimeScale result;
				if ((result = this._TimeScale) == null)
				{
					result = (this._TimeScale = new FKuroBulletDataTimeScale(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_TimeScale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroBulletDataTimeScale.StaticStruct(), base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_TimeScale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x0601534C RID: 86860 RVA: 0x001F2C50 File Offset: 0x001F0E50
		// (set) Token: 0x0601534D RID: 86861 RVA: 0x001F2C93 File Offset: 0x001F0E93
		public TArray<FKuroBulletDataChild> Children
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBulletDataChild> result;
				if ((result = this._Children) == null)
				{
					result = (this._Children = new TArray<FKuroBulletDataChild>(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_Children, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Children.CopyAssign(value);
			}
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x0601534E RID: 86862 RVA: 0x001F2CA4 File Offset: 0x001F0EA4
		// (set) Token: 0x0601534F RID: 86863 RVA: 0x001F2CE7 File Offset: 0x001F0EE7
		public TArray<FKuroBulletGameplayAction> GameplayActionList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroBulletGameplayAction> result;
				if ((result = this._GameplayActionList) == null)
				{
					result = (this._GameplayActionList = new TArray<FKuroBulletGameplayAction>(base.NativePtr + (IntPtr)FKuroBulletData.__PropertyOffset_GameplayActionList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GameplayActionList.CopyAssign(value);
			}
		}

		// Token: 0x06015350 RID: 86864 RVA: 0x001F2CF5 File Offset: 0x001F0EF5
		public FKuroBulletData()
		{
		}

		// Token: 0x06015351 RID: 86865 RVA: 0x001F2D00 File Offset: 0x001F0F00
		public FKuroBulletData(FName Name, FKuroBulletDataBase Base, FKuroBulletDataMove Move, FKuroBulletDataRender Render, FKuroBulletDataLogic Logic, FKuroBulletDataTimeScale TimeScale, TArray<FKuroBulletDataChild> Children, TArray<FKuroBulletGameplayAction> GameplayActionList)
		{
			this.Name = Name;
			this.Base = Base;
			this.Move = Move;
			this.Render = Render;
			this.Logic = Logic;
			this.TimeScale = TimeScale;
			this.Children = Children;
			this.GameplayActionList = GameplayActionList;
		}

		// Token: 0x06015352 RID: 86866 RVA: 0x001F2D50 File Offset: 0x001F0F50
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBulletData.StaticStruct();
		}

		// Token: 0x06015353 RID: 86867 RVA: 0x001F2D5C File Offset: 0x001F0F5C
		[NullableContext(2)]
		public FKuroBulletData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015354 RID: 86868 RVA: 0x001F2D66 File Offset: 0x001F0F66
		public FKuroBulletData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x001F2D71 File Offset: 0x001F0F71
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBulletData(Pointer, false, true);
		}

		// Token: 0x06015356 RID: 86870 RVA: 0x001F2D7B File Offset: 0x001F0F7B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBulletData(Pointer, MemoryOwner);
		}

		// Token: 0x0400B901 RID: 47361
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletData";

		// Token: 0x0400B902 RID: 47362
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B903 RID: 47363
		internal static int __PropertyOffset_Name;

		// Token: 0x0400B904 RID: 47364
		internal static int __PropertyOffset_Base;

		// Token: 0x0400B905 RID: 47365
		[Nullable(2)]
		private FKuroBulletDataBase _Base;

		// Token: 0x0400B906 RID: 47366
		internal static int __PropertyOffset_Move;

		// Token: 0x0400B907 RID: 47367
		[Nullable(2)]
		private FKuroBulletDataMove _Move;

		// Token: 0x0400B908 RID: 47368
		internal static int __PropertyOffset_Render;

		// Token: 0x0400B909 RID: 47369
		[Nullable(2)]
		private FKuroBulletDataRender _Render;

		// Token: 0x0400B90A RID: 47370
		internal static int __PropertyOffset_Logic;

		// Token: 0x0400B90B RID: 47371
		[Nullable(2)]
		private FKuroBulletDataLogic _Logic;

		// Token: 0x0400B90C RID: 47372
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x0400B90D RID: 47373
		[Nullable(2)]
		private FKuroBulletDataTimeScale _TimeScale;

		// Token: 0x0400B90E RID: 47374
		internal static int __PropertyOffset_Children;

		// Token: 0x0400B90F RID: 47375
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBulletDataChild> _Children;

		// Token: 0x0400B910 RID: 47376
		internal static int __PropertyOffset_GameplayActionList;

		// Token: 0x0400B911 RID: 47377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroBulletGameplayAction> _GameplayActionList;
	}
}
