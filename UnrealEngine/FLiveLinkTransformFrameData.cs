using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200222A RID: 8746
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkTransformFrameData")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FLiveLinkTransformFrameData : FLiveLinkBaseFrameData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214D2 RID: 136402 RVA: 0x003115AE File Offset: 0x0030F7AE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkTransformFrameData._ScriptStructPtr != 0) ? FLiveLinkTransformFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkTransformFrameData", ref FLiveLinkTransformFrameData._ScriptStructPtr);
		}

		// Token: 0x170081F7 RID: 33271
		// (get) Token: 0x060214D3 RID: 136403 RVA: 0x003115D2 File Offset: 0x0030F7D2
		// (set) Token: 0x060214D4 RID: 136404 RVA: 0x003115E6 File Offset: 0x0030F7E6
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkTransformFrameData.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkTransformFrameData.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x060214D5 RID: 136405 RVA: 0x003115FB File Offset: 0x0030F7FB
		public FLiveLinkTransformFrameData()
		{
		}

		// Token: 0x060214D6 RID: 136406 RVA: 0x00311603 File Offset: 0x0030F803
		[NullableContext(1)]
		public FLiveLinkTransformFrameData(FTransform Transform, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData, TArray<float> PropertyValues)
		{
			this.Transform = Transform;
			base.WorldTime = WorldTime;
			base.MetaData = MetaData;
			base.PropertyValues = PropertyValues;
		}

		// Token: 0x060214D7 RID: 136407 RVA: 0x00311628 File Offset: 0x0030F828
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkTransformFrameData.StaticStruct();
		}

		// Token: 0x060214D8 RID: 136408 RVA: 0x00311634 File Offset: 0x0030F834
		[NullableContext(2)]
		public FLiveLinkTransformFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214D9 RID: 136409 RVA: 0x0031163E File Offset: 0x0030F83E
		public FLiveLinkTransformFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214DA RID: 136410 RVA: 0x00311649 File Offset: 0x0030F849
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkTransformFrameData(Pointer, false, true);
		}

		// Token: 0x060214DB RID: 136411 RVA: 0x00311653 File Offset: 0x0030F853
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkTransformFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011C23 RID: 72739
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkTransformFrameData";

		// Token: 0x04011C24 RID: 72740
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C25 RID: 72741
		internal static int __PropertyOffset_Transform;
	}
}
