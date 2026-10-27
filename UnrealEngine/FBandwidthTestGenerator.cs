using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008A0 RID: 2208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BandwidthTestGenerator")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FBandwidthTestGenerator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060078C9 RID: 30921 RVA: 0x000ACF5D File Offset: 0x000AB15D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBandwidthTestGenerator._ScriptStructPtr != 0) ? FBandwidthTestGenerator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BandwidthTestGenerator", ref FBandwidthTestGenerator._ScriptStructPtr);
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x000ACF84 File Offset: 0x000AB184
		// (set) Token: 0x060078CB RID: 30923 RVA: 0x000ACFC7 File Offset: 0x000AB1C7
		public TArray<FBandwidthTestItem> ReplicatedBuffers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBandwidthTestItem> result;
				if ((result = this._ReplicatedBuffers) == null)
				{
					result = (this._ReplicatedBuffers = new TArray<FBandwidthTestItem>(base.NativePtr + (IntPtr)FBandwidthTestGenerator.__PropertyOffset_ReplicatedBuffers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ReplicatedBuffers.CopyAssign(value);
			}
		}

		// Token: 0x060078CC RID: 30924 RVA: 0x000ACFD5 File Offset: 0x000AB1D5
		public FBandwidthTestGenerator()
		{
		}

		// Token: 0x060078CD RID: 30925 RVA: 0x000ACFDD File Offset: 0x000AB1DD
		public FBandwidthTestGenerator(TArray<FBandwidthTestItem> ReplicatedBuffers)
		{
			this.ReplicatedBuffers = ReplicatedBuffers;
		}

		// Token: 0x060078CE RID: 30926 RVA: 0x000ACFEC File Offset: 0x000AB1EC
		protected override IntPtr GetUStructPtr()
		{
			return FBandwidthTestGenerator.StaticStruct();
		}

		// Token: 0x060078CF RID: 30927 RVA: 0x000ACFF8 File Offset: 0x000AB1F8
		[NullableContext(2)]
		public FBandwidthTestGenerator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x000AD002 File Offset: 0x000AB202
		public FBandwidthTestGenerator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x000AD00D File Offset: 0x000AB20D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBandwidthTestGenerator(Pointer, false, true);
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x000AD017 File Offset: 0x000AB217
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBandwidthTestGenerator(Pointer, MemoryOwner);
		}

		// Token: 0x04003A05 RID: 14853
		public const string __ObjectPath = "/Script/Engine.BandwidthTestGenerator";

		// Token: 0x04003A06 RID: 14854
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A07 RID: 14855
		internal static int __PropertyOffset_ReplicatedBuffers;

		// Token: 0x04003A08 RID: 14856
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBandwidthTestItem> _ReplicatedBuffers;
	}
}
