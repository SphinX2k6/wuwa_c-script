using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007AC RID: 1964
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorCheckJsonParamsDetail")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FActorCheckJsonParamsDetail : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060068C2 RID: 26818 RVA: 0x000965E4 File Offset: 0x000947E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorCheckJsonParamsDetail._ScriptStructPtr != 0) ? FActorCheckJsonParamsDetail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorCheckJsonParamsDetail", ref FActorCheckJsonParamsDetail._ScriptStructPtr);
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x00096608 File Offset: 0x00094808
		// (set) Token: 0x060068C4 RID: 26820 RVA: 0x0009661C File Offset: 0x0009481C
		public unsafe string Regex
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_Regex)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_Regex)), value);
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x00096634 File Offset: 0x00094834
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x00096677 File Offset: 0x00094877
		public TArray<FActorCheckJsonParamsTopFolders> TopFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorCheckJsonParamsTopFolders> result;
				if ((result = this._TopFolders) == null)
				{
					result = (this._TopFolders = new TArray<FActorCheckJsonParamsTopFolders>(base.NativePtr + (IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_TopFolders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TopFolders.CopyAssign(value);
			}
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x00096688 File Offset: 0x00094888
		// (set) Token: 0x060068C8 RID: 26824 RVA: 0x000966CB File Offset: 0x000948CB
		public TArray<FActorCheckJsonParamsFirstFolders> FirstFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorCheckJsonParamsFirstFolders> result;
				if ((result = this._FirstFolders) == null)
				{
					result = (this._FirstFolders = new TArray<FActorCheckJsonParamsFirstFolders>(base.NativePtr + (IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_FirstFolders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FirstFolders.CopyAssign(value);
			}
		}

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x000966DC File Offset: 0x000948DC
		// (set) Token: 0x060068CA RID: 26826 RVA: 0x0009671F File Offset: 0x0009491F
		public TArray<FActorCheckJsonParamsSecondFolders> SecondFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FActorCheckJsonParamsSecondFolders> result;
				if ((result = this._SecondFolders) == null)
				{
					result = (this._SecondFolders = new TArray<FActorCheckJsonParamsSecondFolders>(base.NativePtr + (IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_SecondFolders, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SecondFolders.CopyAssign(value);
			}
		}

		// Token: 0x170018D3 RID: 6355
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x00096730 File Offset: 0x00094930
		// (set) Token: 0x060068CC RID: 26828 RVA: 0x00096773 File Offset: 0x00094973
		public TArray<string> SecondGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._SecondGroups) == null)
				{
					result = (this._SecondGroups = new TArray<string>(base.NativePtr + (IntPtr)FActorCheckJsonParamsDetail.__PropertyOffset_SecondGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SecondGroups.CopyAssign(value);
			}
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00096781 File Offset: 0x00094981
		public FActorCheckJsonParamsDetail()
		{
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00096789 File Offset: 0x00094989
		public FActorCheckJsonParamsDetail(string Regex, TArray<FActorCheckJsonParamsTopFolders> TopFolders, TArray<FActorCheckJsonParamsFirstFolders> FirstFolders, TArray<FActorCheckJsonParamsSecondFolders> SecondFolders, TArray<string> SecondGroups)
		{
			this.Regex = Regex;
			this.TopFolders = TopFolders;
			this.FirstFolders = FirstFolders;
			this.SecondFolders = SecondFolders;
			this.SecondGroups = SecondGroups;
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x000967B6 File Offset: 0x000949B6
		protected override IntPtr GetUStructPtr()
		{
			return FActorCheckJsonParamsDetail.StaticStruct();
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x000967C2 File Offset: 0x000949C2
		[NullableContext(2)]
		public FActorCheckJsonParamsDetail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x000967CC File Offset: 0x000949CC
		public FActorCheckJsonParamsDetail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x000967D7 File Offset: 0x000949D7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorCheckJsonParamsDetail(Pointer, false, true);
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x000967E1 File Offset: 0x000949E1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorCheckJsonParamsDetail(Pointer, MemoryOwner);
		}

		// Token: 0x04003288 RID: 12936
		public const string __ObjectPath = "/Script/Engine.ActorCheckJsonParamsDetail";

		// Token: 0x04003289 RID: 12937
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400328A RID: 12938
		internal static int __PropertyOffset_Regex;

		// Token: 0x0400328B RID: 12939
		internal static int __PropertyOffset_TopFolders;

		// Token: 0x0400328C RID: 12940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorCheckJsonParamsTopFolders> _TopFolders;

		// Token: 0x0400328D RID: 12941
		internal static int __PropertyOffset_FirstFolders;

		// Token: 0x0400328E RID: 12942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorCheckJsonParamsFirstFolders> _FirstFolders;

		// Token: 0x0400328F RID: 12943
		internal static int __PropertyOffset_SecondFolders;

		// Token: 0x04003290 RID: 12944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FActorCheckJsonParamsSecondFolders> _SecondFolders;

		// Token: 0x04003291 RID: 12945
		internal static int __PropertyOffset_SecondGroups;

		// Token: 0x04003292 RID: 12946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _SecondGroups;
	}
}
