using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002460 RID: 9312
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.SectionEvaluationData")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FSectionEvaluationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022E1A RID: 142874 RVA: 0x003392CA File Offset: 0x003374CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSectionEvaluationData._ScriptStructPtr != 0) ? FSectionEvaluationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.SectionEvaluationData", ref FSectionEvaluationData._ScriptStructPtr);
		}

		// Token: 0x1700860D RID: 34317
		// (get) Token: 0x06022E1B RID: 142875 RVA: 0x003392EE File Offset: 0x003374EE
		// (set) Token: 0x06022E1C RID: 142876 RVA: 0x003392FE File Offset: 0x003374FE
		public unsafe int ImplIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_ImplIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_ImplIndex) = value;
			}
		}

		// Token: 0x1700860E RID: 34318
		// (get) Token: 0x06022E1D RID: 142877 RVA: 0x00339310 File Offset: 0x00337510
		// (set) Token: 0x06022E1E RID: 142878 RVA: 0x00339353 File Offset: 0x00337553
		public FFrameNumber ForcedTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._ForcedTime) == null)
				{
					result = (this._ForcedTime = new FFrameNumber(base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_ForcedTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_ForcedTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700860F RID: 34319
		// (get) Token: 0x06022E1F RID: 142879 RVA: 0x00339374 File Offset: 0x00337574
		// (set) Token: 0x06022E20 RID: 142880 RVA: 0x00339384 File Offset: 0x00337584
		public unsafe ESectionEvaluationFlags Flags
		{
			get
			{
				return (ESectionEvaluationFlags)(*(base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_Flags));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSectionEvaluationData.__PropertyOffset_Flags) = (byte)value;
			}
		}

		// Token: 0x06022E21 RID: 142881 RVA: 0x00339395 File Offset: 0x00337595
		public FSectionEvaluationData()
		{
		}

		// Token: 0x06022E22 RID: 142882 RVA: 0x0033939D File Offset: 0x0033759D
		public FSectionEvaluationData(int ImplIndex, FFrameNumber ForcedTime, ESectionEvaluationFlags Flags)
		{
			this.ImplIndex = ImplIndex;
			this.ForcedTime = ForcedTime;
			this.Flags = Flags;
		}

		// Token: 0x06022E23 RID: 142883 RVA: 0x003393BA File Offset: 0x003375BA
		protected override IntPtr GetUStructPtr()
		{
			return FSectionEvaluationData.StaticStruct();
		}

		// Token: 0x06022E24 RID: 142884 RVA: 0x003393C6 File Offset: 0x003375C6
		[NullableContext(2)]
		public FSectionEvaluationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E25 RID: 142885 RVA: 0x003393D0 File Offset: 0x003375D0
		public FSectionEvaluationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E26 RID: 142886 RVA: 0x003393DB File Offset: 0x003375DB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSectionEvaluationData(Pointer, false, true);
		}

		// Token: 0x06022E27 RID: 142887 RVA: 0x003393E5 File Offset: 0x003375E5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSectionEvaluationData(Pointer, MemoryOwner);
		}

		// Token: 0x040129F0 RID: 76272
		public const string __ObjectPath = "/Script/MovieScene.SectionEvaluationData";

		// Token: 0x040129F1 RID: 76273
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129F2 RID: 76274
		internal static int __PropertyOffset_ImplIndex;

		// Token: 0x040129F3 RID: 76275
		internal static int __PropertyOffset_ForcedTime;

		// Token: 0x040129F4 RID: 76276
		[Nullable(2)]
		private FFrameNumber _ForcedTime;

		// Token: 0x040129F5 RID: 76277
		internal static int __PropertyOffset_Flags;
	}
}
