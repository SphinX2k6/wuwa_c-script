using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D76 RID: 3446
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MarkerSyncData")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMarkerSyncData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600BA87 RID: 47751 RVA: 0x001091C4 File Offset: 0x001073C4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMarkerSyncData._ScriptStructPtr != 0) ? FMarkerSyncData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MarkerSyncData", ref FMarkerSyncData._ScriptStructPtr);
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x001091E8 File Offset: 0x001073E8
		// (set) Token: 0x0600BA89 RID: 47753 RVA: 0x0010922B File Offset: 0x0010742B
		public TArray<FAnimSyncMarker> AuthoredSyncMarkers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimSyncMarker> result;
				if ((result = this._AuthoredSyncMarkers) == null)
				{
					result = (this._AuthoredSyncMarkers = new TArray<FAnimSyncMarker>(base.NativePtr + (IntPtr)FMarkerSyncData.__PropertyOffset_AuthoredSyncMarkers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AuthoredSyncMarkers.CopyAssign(value);
			}
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x00109239 File Offset: 0x00107439
		public FMarkerSyncData()
		{
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x00109241 File Offset: 0x00107441
		public FMarkerSyncData(TArray<FAnimSyncMarker> AuthoredSyncMarkers)
		{
			this.AuthoredSyncMarkers = AuthoredSyncMarkers;
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x00109250 File Offset: 0x00107450
		protected override IntPtr GetUStructPtr()
		{
			return FMarkerSyncData.StaticStruct();
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x0010925C File Offset: 0x0010745C
		[NullableContext(2)]
		public FMarkerSyncData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x00109266 File Offset: 0x00107466
		public FMarkerSyncData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x00109271 File Offset: 0x00107471
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMarkerSyncData(Pointer, false, true);
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x0010927B File Offset: 0x0010747B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMarkerSyncData(Pointer, MemoryOwner);
		}

		// Token: 0x0400619C RID: 24988
		public const string __ObjectPath = "/Script/Engine.MarkerSyncData";

		// Token: 0x0400619D RID: 24989
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400619E RID: 24990
		internal static int __PropertyOffset_AuthoredSyncMarkers;

		// Token: 0x0400619F RID: 24991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimSyncMarker> _AuthoredSyncMarkers;
	}
}
