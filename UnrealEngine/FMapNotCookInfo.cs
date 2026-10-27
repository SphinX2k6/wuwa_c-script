using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D70 RID: 3440
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MapNotCookInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FMapNotCookInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B9C7 RID: 47559 RVA: 0x00108491 File Offset: 0x00106691
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMapNotCookInfo._ScriptStructPtr != 0) ? FMapNotCookInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MapNotCookInfo", ref FMapNotCookInfo._ScriptStructPtr);
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x001084B5 File Offset: 0x001066B5
		// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x001084C9 File Offset: 0x001066C9
		public unsafe string MapName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMapNotCookInfo.__PropertyOffset_MapName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMapNotCookInfo.__PropertyOffset_MapName)), value);
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x0600B9CA RID: 47562 RVA: 0x001084DE File Offset: 0x001066DE
		// (set) Token: 0x0600B9CB RID: 47563 RVA: 0x001084EE File Offset: 0x001066EE
		public unsafe bool bMapNotCooked
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMapNotCookInfo.__PropertyOffset_bMapNotCooked) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMapNotCookInfo.__PropertyOffset_bMapNotCooked) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x0600B9CC RID: 47564 RVA: 0x00108500 File Offset: 0x00106700
		// (set) Token: 0x0600B9CD RID: 47565 RVA: 0x00108543 File Offset: 0x00106743
		public TSet<FName> NotCookedGrids
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._NotCookedGrids) == null)
				{
					result = (this._NotCookedGrids = new TSet<FName>(base.NativePtr + (IntPtr)FMapNotCookInfo.__PropertyOffset_NotCookedGrids, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NotCookedGrids.CopyAssign(value);
			}
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x00108551 File Offset: 0x00106751
		public FMapNotCookInfo()
		{
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x00108559 File Offset: 0x00106759
		public FMapNotCookInfo(string MapName, bool bMapNotCooked, TSet<FName> NotCookedGrids)
		{
			this.MapName = MapName;
			this.bMapNotCooked = bMapNotCooked;
			this.NotCookedGrids = NotCookedGrids;
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x00108576 File Offset: 0x00106776
		protected override IntPtr GetUStructPtr()
		{
			return FMapNotCookInfo.StaticStruct();
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x00108582 File Offset: 0x00106782
		[NullableContext(2)]
		public FMapNotCookInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x0010858C File Offset: 0x0010678C
		public FMapNotCookInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x00108597 File Offset: 0x00106797
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMapNotCookInfo(Pointer, false, true);
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x001085A1 File Offset: 0x001067A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMapNotCookInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04006152 RID: 24914
		public const string __ObjectPath = "/Script/Engine.MapNotCookInfo";

		// Token: 0x04006153 RID: 24915
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006154 RID: 24916
		internal static int __PropertyOffset_MapName;

		// Token: 0x04006155 RID: 24917
		internal static int __PropertyOffset_bMapNotCooked;

		// Token: 0x04006156 RID: 24918
		internal static int __PropertyOffset_NotCookedGrids;

		// Token: 0x04006157 RID: 24919
		[Nullable(2)]
		private TSet<FName> _NotCookedGrids;
	}
}
