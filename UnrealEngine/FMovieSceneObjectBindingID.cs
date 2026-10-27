using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200241A RID: 9242
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectBindingID")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMovieSceneObjectBindingID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A2F RID: 141871 RVA: 0x00333922 File Offset: 0x00331B22
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectBindingID._ScriptStructPtr != 0) ? FMovieSceneObjectBindingID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectBindingID", ref FMovieSceneObjectBindingID._ScriptStructPtr);
		}

		// Token: 0x17008548 RID: 34120
		// (get) Token: 0x06022A30 RID: 141872 RVA: 0x00333946 File Offset: 0x00331B46
		// (set) Token: 0x06022A31 RID: 141873 RVA: 0x00333956 File Offset: 0x00331B56
		public unsafe int SequenceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_SequenceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_SequenceID) = value;
			}
		}

		// Token: 0x17008549 RID: 34121
		// (get) Token: 0x06022A32 RID: 141874 RVA: 0x00333967 File Offset: 0x00331B67
		// (set) Token: 0x06022A33 RID: 141875 RVA: 0x00333977 File Offset: 0x00331B77
		public unsafe EMovieSceneObjectBindingSpace Space
		{
			get
			{
				return (EMovieSceneObjectBindingSpace)(*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x1700854A RID: 34122
		// (get) Token: 0x06022A34 RID: 141876 RVA: 0x00333988 File Offset: 0x00331B88
		// (set) Token: 0x06022A35 RID: 141877 RVA: 0x0033399C File Offset: 0x00331B9C
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneObjectBindingID.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x06022A36 RID: 141878 RVA: 0x003339B1 File Offset: 0x00331BB1
		public FMovieSceneObjectBindingID()
		{
		}

		// Token: 0x06022A37 RID: 141879 RVA: 0x003339B9 File Offset: 0x00331BB9
		public FMovieSceneObjectBindingID(int SequenceID, EMovieSceneObjectBindingSpace Space, FGuid Guid)
		{
			this.SequenceID = SequenceID;
			this.Space = Space;
			this.Guid = Guid;
		}

		// Token: 0x06022A38 RID: 141880 RVA: 0x003339D6 File Offset: 0x00331BD6
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectBindingID.StaticStruct();
		}

		// Token: 0x06022A39 RID: 141881 RVA: 0x003339E2 File Offset: 0x00331BE2
		[NullableContext(2)]
		public FMovieSceneObjectBindingID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A3A RID: 141882 RVA: 0x003339EC File Offset: 0x00331BEC
		public FMovieSceneObjectBindingID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A3B RID: 141883 RVA: 0x003339F7 File Offset: 0x00331BF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectBindingID(Pointer, false, true);
		}

		// Token: 0x06022A3C RID: 141884 RVA: 0x00333A01 File Offset: 0x00331C01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectBindingID(Pointer, MemoryOwner);
		}

		// Token: 0x0401281C RID: 75804
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectBindingID";

		// Token: 0x0401281D RID: 75805
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401281E RID: 75806
		internal static int __PropertyOffset_SequenceID;

		// Token: 0x0401281F RID: 75807
		internal static int __PropertyOffset_Space;

		// Token: 0x04012820 RID: 75808
		internal static int __PropertyOffset_Guid;
	}
}
