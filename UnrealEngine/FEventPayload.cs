using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002322 RID: 8994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.EventPayload")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FEventPayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022080 RID: 139392 RVA: 0x00324F81 File Offset: 0x00323181
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEventPayload._ScriptStructPtr != 0) ? FEventPayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.EventPayload", ref FEventPayload._ScriptStructPtr);
		}

		// Token: 0x1700837B RID: 33659
		// (get) Token: 0x06022081 RID: 139393 RVA: 0x00324FA5 File Offset: 0x003231A5
		// (set) Token: 0x06022082 RID: 139394 RVA: 0x00324FB9 File Offset: 0x003231B9
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEventPayload.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEventPayload.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x1700837C RID: 33660
		// (get) Token: 0x06022083 RID: 139395 RVA: 0x00324FD0 File Offset: 0x003231D0
		// (set) Token: 0x06022084 RID: 139396 RVA: 0x00325013 File Offset: 0x00323213
		public FMovieSceneEventParameters Parameters
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEventParameters result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new FMovieSceneEventParameters(base.NativePtr + (IntPtr)FEventPayload.__PropertyOffset_Parameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEventParameters.StaticStruct(), base.NativePtr + (IntPtr)FEventPayload.__PropertyOffset_Parameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022085 RID: 139397 RVA: 0x00325034 File Offset: 0x00323234
		public FEventPayload()
		{
		}

		// Token: 0x06022086 RID: 139398 RVA: 0x0032503C File Offset: 0x0032323C
		public FEventPayload(FName EventName, FMovieSceneEventParameters Parameters)
		{
			this.EventName = EventName;
			this.Parameters = Parameters;
		}

		// Token: 0x06022087 RID: 139399 RVA: 0x00325052 File Offset: 0x00323252
		protected override IntPtr GetUStructPtr()
		{
			return FEventPayload.StaticStruct();
		}

		// Token: 0x06022088 RID: 139400 RVA: 0x0032505E File Offset: 0x0032325E
		[NullableContext(2)]
		public FEventPayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022089 RID: 139401 RVA: 0x00325068 File Offset: 0x00323268
		public FEventPayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602208A RID: 139402 RVA: 0x00325073 File Offset: 0x00323273
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEventPayload(Pointer, false, true);
		}

		// Token: 0x0602208B RID: 139403 RVA: 0x0032507D File Offset: 0x0032327D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEventPayload(Pointer, MemoryOwner);
		}

		// Token: 0x0401228E RID: 74382
		public const string __ObjectPath = "/Script/MovieSceneTracks.EventPayload";

		// Token: 0x0401228F RID: 74383
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012290 RID: 74384
		internal static int __PropertyOffset_EventName;

		// Token: 0x04012291 RID: 74385
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04012292 RID: 74386
		[Nullable(2)]
		private FMovieSceneEventParameters _Parameters;
	}
}
