using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000845 RID: 2117
	[UnrealObjectPath("/Script/Engine.AnimSyncMarker")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FAnimSyncMarker : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007211 RID: 29201 RVA: 0x000A356B File Offset: 0x000A176B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSyncMarker._ScriptStructPtr != 0) ? FAnimSyncMarker._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSyncMarker", ref FAnimSyncMarker._ScriptStructPtr);
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06007212 RID: 29202 RVA: 0x000A358F File Offset: 0x000A178F
		// (set) Token: 0x06007213 RID: 29203 RVA: 0x000A35A3 File Offset: 0x000A17A3
		public unsafe FName MarkerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSyncMarker.__PropertyOffset_MarkerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSyncMarker.__PropertyOffset_MarkerName) = value;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06007214 RID: 29204 RVA: 0x000A35B8 File Offset: 0x000A17B8
		// (set) Token: 0x06007215 RID: 29205 RVA: 0x000A35C8 File Offset: 0x000A17C8
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSyncMarker.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSyncMarker.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x000A35D9 File Offset: 0x000A17D9
		public FAnimSyncMarker()
		{
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x000A35E1 File Offset: 0x000A17E1
		public FAnimSyncMarker(FName MarkerName, float Time, int TrackIndex, FGuid Guid)
		{
			this.MarkerName = MarkerName;
			this.Time = Time;
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x000A35F7 File Offset: 0x000A17F7
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSyncMarker.StaticStruct();
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x000A3603 File Offset: 0x000A1803
		[NullableContext(2)]
		public FAnimSyncMarker(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x000A360D File Offset: 0x000A180D
		public FAnimSyncMarker(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600721B RID: 29211 RVA: 0x000A3618 File Offset: 0x000A1818
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSyncMarker(Pointer, false, true);
		}

		// Token: 0x0600721C RID: 29212 RVA: 0x000A3622 File Offset: 0x000A1822
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSyncMarker(Pointer, MemoryOwner);
		}

		// Token: 0x040036C8 RID: 14024
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimSyncMarker";

		// Token: 0x040036C9 RID: 14025
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036CA RID: 14026
		internal static int __PropertyOffset_MarkerName;

		// Token: 0x040036CB RID: 14027
		internal static int __PropertyOffset_Time;
	}
}
