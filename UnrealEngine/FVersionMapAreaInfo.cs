using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001229 RID: 4649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VersionMapAreaInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FVersionMapAreaInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060111AF RID: 70063 RVA: 0x00191950 File Offset: 0x0018FB50
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVersionMapAreaInfo._ScriptStructPtr != 0) ? FVersionMapAreaInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VersionMapAreaInfo", ref FVersionMapAreaInfo._ScriptStructPtr);
		}

		// Token: 0x170042C7 RID: 17095
		// (get) Token: 0x060111B0 RID: 70064 RVA: 0x00191974 File Offset: 0x0018FB74
		// (set) Token: 0x060111B1 RID: 70065 RVA: 0x00191988 File Offset: 0x0018FB88
		public unsafe string Version
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FVersionMapAreaInfo.__PropertyOffset_Version)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FVersionMapAreaInfo.__PropertyOffset_Version)), value);
			}
		}

		// Token: 0x170042C8 RID: 17096
		// (get) Token: 0x060111B2 RID: 70066 RVA: 0x001919A0 File Offset: 0x0018FBA0
		// (set) Token: 0x060111B3 RID: 70067 RVA: 0x001919E3 File Offset: 0x0018FBE3
		public TArray<FMapAreaInfo> MapAreaStruct
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMapAreaInfo> result;
				if ((result = this._MapAreaStruct) == null)
				{
					result = (this._MapAreaStruct = new TArray<FMapAreaInfo>(base.NativePtr + (IntPtr)FVersionMapAreaInfo.__PropertyOffset_MapAreaStruct, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MapAreaStruct.CopyAssign(value);
			}
		}

		// Token: 0x060111B4 RID: 70068 RVA: 0x001919F1 File Offset: 0x0018FBF1
		public FVersionMapAreaInfo()
		{
		}

		// Token: 0x060111B5 RID: 70069 RVA: 0x001919F9 File Offset: 0x0018FBF9
		public FVersionMapAreaInfo(string Version, TArray<FMapAreaInfo> MapAreaStruct)
		{
			this.Version = Version;
			this.MapAreaStruct = MapAreaStruct;
		}

		// Token: 0x060111B6 RID: 70070 RVA: 0x00191A0F File Offset: 0x0018FC0F
		protected override IntPtr GetUStructPtr()
		{
			return FVersionMapAreaInfo.StaticStruct();
		}

		// Token: 0x060111B7 RID: 70071 RVA: 0x00191A1B File Offset: 0x0018FC1B
		[NullableContext(2)]
		public FVersionMapAreaInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111B8 RID: 70072 RVA: 0x00191A25 File Offset: 0x0018FC25
		public FVersionMapAreaInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111B9 RID: 70073 RVA: 0x00191A30 File Offset: 0x0018FC30
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVersionMapAreaInfo(Pointer, false, true);
		}

		// Token: 0x060111BA RID: 70074 RVA: 0x00191A3A File Offset: 0x0018FC3A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVersionMapAreaInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009281 RID: 37505
		public const string __ObjectPath = "/Script/Engine.VersionMapAreaInfo";

		// Token: 0x04009282 RID: 37506
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009283 RID: 37507
		internal static int __PropertyOffset_Version;

		// Token: 0x04009284 RID: 37508
		internal static int __PropertyOffset_MapAreaStruct;

		// Token: 0x04009285 RID: 37509
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMapAreaInfo> _MapAreaStruct;
	}
}
