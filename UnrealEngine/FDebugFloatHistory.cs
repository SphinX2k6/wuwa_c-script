using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009A8 RID: 2472
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DebugFloatHistory")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FDebugFloatHistory : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B89 RID: 35721 RVA: 0x000C7E8A File Offset: 0x000C608A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugFloatHistory._ScriptStructPtr != 0) ? FDebugFloatHistory._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DebugFloatHistory", ref FDebugFloatHistory._ScriptStructPtr);
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06008B8A RID: 35722 RVA: 0x000C7EB0 File Offset: 0x000C60B0
		// (set) Token: 0x06008B8B RID: 35723 RVA: 0x000C7EF3 File Offset: 0x000C60F3
		public TArray<float> Samples
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Samples) == null)
				{
					result = (this._Samples = new TArray<float>(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_Samples, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Samples.CopyAssign(value);
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06008B8C RID: 35724 RVA: 0x000C7F01 File Offset: 0x000C6101
		// (set) Token: 0x06008B8D RID: 35725 RVA: 0x000C7F11 File Offset: 0x000C6111
		public unsafe float MaxSamples
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MaxSamples);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MaxSamples) = value;
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06008B8E RID: 35726 RVA: 0x000C7F22 File Offset: 0x000C6122
		// (set) Token: 0x06008B8F RID: 35727 RVA: 0x000C7F32 File Offset: 0x000C6132
		public unsafe float MinValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MinValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MinValue) = value;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06008B90 RID: 35728 RVA: 0x000C7F43 File Offset: 0x000C6143
		// (set) Token: 0x06008B91 RID: 35729 RVA: 0x000C7F53 File Offset: 0x000C6153
		public unsafe float MaxValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MaxValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_MaxValue) = value;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06008B92 RID: 35730 RVA: 0x000C7F64 File Offset: 0x000C6164
		// (set) Token: 0x06008B93 RID: 35731 RVA: 0x000C7F74 File Offset: 0x000C6174
		public unsafe bool bAutoAdjustMinMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_bAutoAdjustMinMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugFloatHistory.__PropertyOffset_bAutoAdjustMinMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x000C7F85 File Offset: 0x000C6185
		public FDebugFloatHistory()
		{
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x000C7F8D File Offset: 0x000C618D
		public FDebugFloatHistory(TArray<float> Samples, float MaxSamples, float MinValue, float MaxValue, bool bAutoAdjustMinMax)
		{
			this.Samples = Samples;
			this.MaxSamples = MaxSamples;
			this.MinValue = MinValue;
			this.MaxValue = MaxValue;
			this.bAutoAdjustMinMax = bAutoAdjustMinMax;
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x000C7FBA File Offset: 0x000C61BA
		protected override IntPtr GetUStructPtr()
		{
			return FDebugFloatHistory.StaticStruct();
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x000C7FC6 File Offset: 0x000C61C6
		[NullableContext(2)]
		public FDebugFloatHistory(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x000C7FD0 File Offset: 0x000C61D0
		public FDebugFloatHistory(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x000C7FDB File Offset: 0x000C61DB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugFloatHistory(Pointer, false, true);
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x000C7FE5 File Offset: 0x000C61E5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugFloatHistory(Pointer, MemoryOwner);
		}

		// Token: 0x04004249 RID: 16969
		public const string __ObjectPath = "/Script/Engine.DebugFloatHistory";

		// Token: 0x0400424A RID: 16970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400424B RID: 16971
		internal static int __PropertyOffset_Samples;

		// Token: 0x0400424C RID: 16972
		[Nullable(2)]
		private TArray<float> _Samples;

		// Token: 0x0400424D RID: 16973
		internal static int __PropertyOffset_MaxSamples;

		// Token: 0x0400424E RID: 16974
		internal static int __PropertyOffset_MinValue;

		// Token: 0x0400424F RID: 16975
		internal static int __PropertyOffset_MaxValue;

		// Token: 0x04004250 RID: 16976
		internal static int __PropertyOffset_bAutoAdjustMinMax;
	}
}
