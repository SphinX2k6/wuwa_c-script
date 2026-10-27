using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002984 RID: 10628
	[UnrealObjectPath("/Script/UMG.MovieScene2DTransformMask")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieScene2DTransformMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06027575 RID: 161141 RVA: 0x003BF8EF File Offset: 0x003BDAEF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieScene2DTransformMask._ScriptStructPtr != 0) ? FMovieScene2DTransformMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.MovieScene2DTransformMask", ref FMovieScene2DTransformMask._ScriptStructPtr);
		}

		// Token: 0x17009733 RID: 38707
		// (get) Token: 0x06027576 RID: 161142 RVA: 0x003BF913 File Offset: 0x003BDB13
		// (set) Token: 0x06027577 RID: 161143 RVA: 0x003BF923 File Offset: 0x003BDB23
		public unsafe uint Mask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieScene2DTransformMask.__PropertyOffset_Mask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieScene2DTransformMask.__PropertyOffset_Mask) = (int)value;
			}
		}

		// Token: 0x06027578 RID: 161144 RVA: 0x003BF934 File Offset: 0x003BDB34
		public FMovieScene2DTransformMask()
		{
		}

		// Token: 0x06027579 RID: 161145 RVA: 0x003BF93C File Offset: 0x003BDB3C
		public FMovieScene2DTransformMask(uint Mask)
		{
			this.Mask = Mask;
		}

		// Token: 0x0602757A RID: 161146 RVA: 0x003BF94B File Offset: 0x003BDB4B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieScene2DTransformMask.StaticStruct();
		}

		// Token: 0x0602757B RID: 161147 RVA: 0x003BF957 File Offset: 0x003BDB57
		[NullableContext(2)]
		public FMovieScene2DTransformMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602757C RID: 161148 RVA: 0x003BF961 File Offset: 0x003BDB61
		public FMovieScene2DTransformMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602757D RID: 161149 RVA: 0x003BF96C File Offset: 0x003BDB6C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieScene2DTransformMask(Pointer, false, true);
		}

		// Token: 0x0602757E RID: 161150 RVA: 0x003BF976 File Offset: 0x003BDB76
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieScene2DTransformMask(Pointer, MemoryOwner);
		}

		// Token: 0x0401599D RID: 88477
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.MovieScene2DTransformMask";

		// Token: 0x0401599E RID: 88478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401599F RID: 88479
		internal static int __PropertyOffset_Mask;
	}
}
