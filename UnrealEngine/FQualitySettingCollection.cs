using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002288 RID: 8840
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MagtModule.QualitySettingCollection")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FQualitySettingCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219BF RID: 137663 RVA: 0x0031B956 File Offset: 0x00319B56
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQualitySettingCollection._ScriptStructPtr != 0) ? FQualitySettingCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MagtModule.QualitySettingCollection", ref FQualitySettingCollection._ScriptStructPtr);
		}

		// Token: 0x17008293 RID: 33427
		// (get) Token: 0x060219C0 RID: 137664 RVA: 0x0031B97A File Offset: 0x00319B7A
		// (set) Token: 0x060219C1 RID: 137665 RVA: 0x0031B98A File Offset: 0x00319B8A
		public unsafe EPerformJudgement PerformJudgement
		{
			get
			{
				return (EPerformJudgement)(*(base.NativePtr + (IntPtr)FQualitySettingCollection.__PropertyOffset_PerformJudgement));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySettingCollection.__PropertyOffset_PerformJudgement) = (byte)value;
			}
		}

		// Token: 0x17008294 RID: 33428
		// (get) Token: 0x060219C2 RID: 137666 RVA: 0x0031B99B File Offset: 0x00319B9B
		// (set) Token: 0x060219C3 RID: 137667 RVA: 0x0031B9AF File Offset: 0x00319BAF
		public unsafe string CollectionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FQualitySettingCollection.__PropertyOffset_CollectionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FQualitySettingCollection.__PropertyOffset_CollectionName)), value);
			}
		}

		// Token: 0x17008295 RID: 33429
		// (get) Token: 0x060219C4 RID: 137668 RVA: 0x0031B9C4 File Offset: 0x00319BC4
		// (set) Token: 0x060219C5 RID: 137669 RVA: 0x0031B9D4 File Offset: 0x00319BD4
		public unsafe int PowerPreference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FQualitySettingCollection.__PropertyOffset_PowerPreference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FQualitySettingCollection.__PropertyOffset_PowerPreference) = value;
			}
		}

		// Token: 0x17008296 RID: 33430
		// (get) Token: 0x060219C6 RID: 137670 RVA: 0x0031B9E8 File Offset: 0x00319BE8
		// (set) Token: 0x060219C7 RID: 137671 RVA: 0x0031BA2B File Offset: 0x00319C2B
		public TArray<FQualitySetting> Collection
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQualitySetting> result;
				if ((result = this._Collection) == null)
				{
					result = (this._Collection = new TArray<FQualitySetting>(base.NativePtr + (IntPtr)FQualitySettingCollection.__PropertyOffset_Collection, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Collection.CopyAssign(value);
			}
		}

		// Token: 0x060219C8 RID: 137672 RVA: 0x0031BA39 File Offset: 0x00319C39
		public FQualitySettingCollection()
		{
		}

		// Token: 0x060219C9 RID: 137673 RVA: 0x0031BA41 File Offset: 0x00319C41
		public FQualitySettingCollection(EPerformJudgement PerformJudgement, string CollectionName, int PowerPreference, TArray<FQualitySetting> Collection)
		{
			this.PerformJudgement = PerformJudgement;
			this.CollectionName = CollectionName;
			this.PowerPreference = PowerPreference;
			this.Collection = Collection;
		}

		// Token: 0x060219CA RID: 137674 RVA: 0x0031BA66 File Offset: 0x00319C66
		protected override IntPtr GetUStructPtr()
		{
			return FQualitySettingCollection.StaticStruct();
		}

		// Token: 0x060219CB RID: 137675 RVA: 0x0031BA72 File Offset: 0x00319C72
		[NullableContext(2)]
		public FQualitySettingCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219CC RID: 137676 RVA: 0x0031BA7C File Offset: 0x00319C7C
		public FQualitySettingCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219CD RID: 137677 RVA: 0x0031BA87 File Offset: 0x00319C87
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FQualitySettingCollection(Pointer, false, true);
		}

		// Token: 0x060219CE RID: 137678 RVA: 0x0031BA91 File Offset: 0x00319C91
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FQualitySettingCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04011F1D RID: 73501
		public const string __ObjectPath = "/Script/MagtModule.QualitySettingCollection";

		// Token: 0x04011F1E RID: 73502
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F1F RID: 73503
		internal static int __PropertyOffset_PerformJudgement;

		// Token: 0x04011F20 RID: 73504
		internal static int __PropertyOffset_CollectionName;

		// Token: 0x04011F21 RID: 73505
		internal static int __PropertyOffset_PowerPreference;

		// Token: 0x04011F22 RID: 73506
		internal static int __PropertyOffset_Collection;

		// Token: 0x04011F23 RID: 73507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FQualitySetting> _Collection;
	}
}
