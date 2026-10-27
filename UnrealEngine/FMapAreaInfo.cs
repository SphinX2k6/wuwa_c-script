using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D6C RID: 3436
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MapAreaInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMapAreaInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B994 RID: 47508 RVA: 0x001080BC File Offset: 0x001062BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMapAreaInfo._ScriptStructPtr != 0) ? FMapAreaInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MapAreaInfo", ref FMapAreaInfo._ScriptStructPtr);
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x001080E0 File Offset: 0x001062E0
		// (set) Token: 0x0600B996 RID: 47510 RVA: 0x001080F4 File Offset: 0x001062F4
		public unsafe string Map
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMapAreaInfo.__PropertyOffset_Map)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMapAreaInfo.__PropertyOffset_Map)), value);
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600B997 RID: 47511 RVA: 0x00108109 File Offset: 0x00106309
		// (set) Token: 0x0600B998 RID: 47512 RVA: 0x0010811D File Offset: 0x0010631D
		public unsafe string MapVersion
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMapAreaInfo.__PropertyOffset_MapVersion)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMapAreaInfo.__PropertyOffset_MapVersion)), value);
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600B999 RID: 47513 RVA: 0x00108134 File Offset: 0x00106334
		// (set) Token: 0x0600B99A RID: 47514 RVA: 0x00108177 File Offset: 0x00106377
		public TArray<string> Areas
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Areas) == null)
				{
					result = (this._Areas = new TArray<string>(base.NativePtr + (IntPtr)FMapAreaInfo.__PropertyOffset_Areas, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Areas.CopyAssign(value);
			}
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x00108185 File Offset: 0x00106385
		public FMapAreaInfo()
		{
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x0010818D File Offset: 0x0010638D
		public FMapAreaInfo(string Map, string MapVersion, TArray<string> Areas)
		{
			this.Map = Map;
			this.MapVersion = MapVersion;
			this.Areas = Areas;
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x001081AA File Offset: 0x001063AA
		protected override IntPtr GetUStructPtr()
		{
			return FMapAreaInfo.StaticStruct();
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x001081B6 File Offset: 0x001063B6
		[NullableContext(2)]
		public FMapAreaInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x001081C0 File Offset: 0x001063C0
		public FMapAreaInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x001081CB File Offset: 0x001063CB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMapAreaInfo(Pointer, false, true);
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x001081D5 File Offset: 0x001063D5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMapAreaInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400613D RID: 24893
		public const string __ObjectPath = "/Script/Engine.MapAreaInfo";

		// Token: 0x0400613E RID: 24894
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400613F RID: 24895
		internal static int __PropertyOffset_Map;

		// Token: 0x04006140 RID: 24896
		internal static int __PropertyOffset_MapVersion;

		// Token: 0x04006141 RID: 24897
		internal static int __PropertyOffset_Areas;

		// Token: 0x04006142 RID: 24898
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Areas;
	}
}
