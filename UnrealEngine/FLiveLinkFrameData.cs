using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002202 RID: 8706
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkFrameData")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FLiveLinkFrameData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060212C9 RID: 135881 RVA: 0x0030E931 File Offset: 0x0030CB31
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkFrameData._ScriptStructPtr != 0) ? FLiveLinkFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkFrameData", ref FLiveLinkFrameData._ScriptStructPtr);
		}

		// Token: 0x17008180 RID: 33152
		// (get) Token: 0x060212CA RID: 135882 RVA: 0x0030E958 File Offset: 0x0030CB58
		// (set) Token: 0x060212CB RID: 135883 RVA: 0x0030E99B File Offset: 0x0030CB9B
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x17008181 RID: 33153
		// (get) Token: 0x060212CC RID: 135884 RVA: 0x0030E9AC File Offset: 0x0030CBAC
		// (set) Token: 0x060212CD RID: 135885 RVA: 0x0030E9EF File Offset: 0x0030CBEF
		public TArray<FLiveLinkCurveElement> CurveElements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLiveLinkCurveElement> result;
				if ((result = this._CurveElements) == null)
				{
					result = (this._CurveElements = new TArray<FLiveLinkCurveElement>(base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_CurveElements, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CurveElements.CopyAssign(value);
			}
		}

		// Token: 0x17008182 RID: 33154
		// (get) Token: 0x060212CE RID: 135886 RVA: 0x0030EA00 File Offset: 0x0030CC00
		// (set) Token: 0x060212CF RID: 135887 RVA: 0x0030EA43 File Offset: 0x0030CC43
		public FLiveLinkWorldTime WorldTime
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkWorldTime result;
				if ((result = this._WorldTime) == null)
				{
					result = (this._WorldTime = new FLiveLinkWorldTime(base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_WorldTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkWorldTime.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_WorldTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008183 RID: 33155
		// (get) Token: 0x060212D0 RID: 135888 RVA: 0x0030EA64 File Offset: 0x0030CC64
		// (set) Token: 0x060212D1 RID: 135889 RVA: 0x0030EAA7 File Offset: 0x0030CCA7
		public FLiveLinkMetaData MetaData
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkMetaData result;
				if ((result = this._MetaData) == null)
				{
					result = (this._MetaData = new FLiveLinkMetaData(base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_MetaData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkMetaData.StaticStruct(), base.NativePtr + (IntPtr)FLiveLinkFrameData.__PropertyOffset_MetaData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060212D2 RID: 135890 RVA: 0x0030EAC8 File Offset: 0x0030CCC8
		public FLiveLinkFrameData()
		{
		}

		// Token: 0x060212D3 RID: 135891 RVA: 0x0030EAD0 File Offset: 0x0030CCD0
		public FLiveLinkFrameData(TArray<FTransform> Transforms, TArray<FLiveLinkCurveElement> CurveElements, FLiveLinkWorldTime WorldTime, FLiveLinkMetaData MetaData)
		{
			this.Transforms = Transforms;
			this.CurveElements = CurveElements;
			this.WorldTime = WorldTime;
			this.MetaData = MetaData;
		}

		// Token: 0x060212D4 RID: 135892 RVA: 0x0030EAF5 File Offset: 0x0030CCF5
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkFrameData.StaticStruct();
		}

		// Token: 0x060212D5 RID: 135893 RVA: 0x0030EB01 File Offset: 0x0030CD01
		[NullableContext(2)]
		public FLiveLinkFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060212D6 RID: 135894 RVA: 0x0030EB0B File Offset: 0x0030CD0B
		public FLiveLinkFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060212D7 RID: 135895 RVA: 0x0030EB16 File Offset: 0x0030CD16
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkFrameData(Pointer, false, true);
		}

		// Token: 0x060212D8 RID: 135896 RVA: 0x0030EB20 File Offset: 0x0030CD20
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x04011B2E RID: 72494
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkFrameData";

		// Token: 0x04011B2F RID: 72495
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011B30 RID: 72496
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04011B31 RID: 72497
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04011B32 RID: 72498
		internal static int __PropertyOffset_CurveElements;

		// Token: 0x04011B33 RID: 72499
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLiveLinkCurveElement> _CurveElements;

		// Token: 0x04011B34 RID: 72500
		internal static int __PropertyOffset_WorldTime;

		// Token: 0x04011B35 RID: 72501
		[Nullable(2)]
		private FLiveLinkWorldTime _WorldTime;

		// Token: 0x04011B36 RID: 72502
		internal static int __PropertyOffset_MetaData;

		// Token: 0x04011B37 RID: 72503
		[Nullable(2)]
		private FLiveLinkMetaData _MetaData;
	}
}
