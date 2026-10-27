using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002337 RID: 9015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneActorReferenceKey")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FMovieSceneActorReferenceKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022179 RID: 139641 RVA: 0x003267F7 File Offset: 0x003249F7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneActorReferenceKey._ScriptStructPtr != 0) ? FMovieSceneActorReferenceKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneActorReferenceKey", ref FMovieSceneActorReferenceKey._ScriptStructPtr);
		}

		// Token: 0x170083B4 RID: 33716
		// (get) Token: 0x0602217A RID: 139642 RVA: 0x0032681C File Offset: 0x00324A1C
		// (set) Token: 0x0602217B RID: 139643 RVA: 0x0032685F File Offset: 0x00324A5F
		public FMovieSceneObjectBindingID Object
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._Object) == null)
				{
					result = (this._Object = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_Object, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_Object, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083B5 RID: 33717
		// (get) Token: 0x0602217C RID: 139644 RVA: 0x00326880 File Offset: 0x00324A80
		// (set) Token: 0x0602217D RID: 139645 RVA: 0x00326894 File Offset: 0x00324A94
		public unsafe FName ComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_ComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_ComponentName) = value;
			}
		}

		// Token: 0x170083B6 RID: 33718
		// (get) Token: 0x0602217E RID: 139646 RVA: 0x003268A9 File Offset: 0x00324AA9
		// (set) Token: 0x0602217F RID: 139647 RVA: 0x003268BD File Offset: 0x00324ABD
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneActorReferenceKey.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x06022180 RID: 139648 RVA: 0x003268D2 File Offset: 0x00324AD2
		public FMovieSceneActorReferenceKey()
		{
		}

		// Token: 0x06022181 RID: 139649 RVA: 0x003268DA File Offset: 0x00324ADA
		public FMovieSceneActorReferenceKey(FMovieSceneObjectBindingID Object, FName ComponentName, FName SocketName)
		{
			this.Object = Object;
			this.ComponentName = ComponentName;
			this.SocketName = SocketName;
		}

		// Token: 0x06022182 RID: 139650 RVA: 0x003268F7 File Offset: 0x00324AF7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneActorReferenceKey.StaticStruct();
		}

		// Token: 0x06022183 RID: 139651 RVA: 0x00326903 File Offset: 0x00324B03
		[NullableContext(2)]
		public FMovieSceneActorReferenceKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022184 RID: 139652 RVA: 0x0032690D File Offset: 0x00324B0D
		public FMovieSceneActorReferenceKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022185 RID: 139653 RVA: 0x00326918 File Offset: 0x00324B18
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneActorReferenceKey(Pointer, false, true);
		}

		// Token: 0x06022186 RID: 139654 RVA: 0x00326922 File Offset: 0x00324B22
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneActorReferenceKey(Pointer, MemoryOwner);
		}

		// Token: 0x04012322 RID: 74530
		public const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneActorReferenceKey";

		// Token: 0x04012323 RID: 74531
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012324 RID: 74532
		internal static int __PropertyOffset_Object;

		// Token: 0x04012325 RID: 74533
		[Nullable(2)]
		private FMovieSceneObjectBindingID _Object;

		// Token: 0x04012326 RID: 74534
		internal static int __PropertyOffset_ComponentName;

		// Token: 0x04012327 RID: 74535
		internal static int __PropertyOffset_SocketName;
	}
}
