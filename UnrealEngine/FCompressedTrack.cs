using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200096A RID: 2410
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CompressedTrack")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FCompressedTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600880A RID: 34826 RVA: 0x000C2E50 File Offset: 0x000C1050
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCompressedTrack._ScriptStructPtr != 0) ? FCompressedTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CompressedTrack", ref FCompressedTrack._ScriptStructPtr);
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x0600880B RID: 34827 RVA: 0x000C2E74 File Offset: 0x000C1074
		// (set) Token: 0x0600880C RID: 34828 RVA: 0x000C2EB7 File Offset: 0x000C10B7
		public TArray<byte> ByteStream
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ByteStream) == null)
				{
					result = (this._ByteStream = new TArray<byte>(base.NativePtr + (IntPtr)FCompressedTrack.__PropertyOffset_ByteStream, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ByteStream.CopyAssign(value);
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x000C2EC8 File Offset: 0x000C10C8
		// (set) Token: 0x0600880E RID: 34830 RVA: 0x000C2F0B File Offset: 0x000C110B
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FCompressedTrack.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600880F RID: 34831 RVA: 0x000C2F1C File Offset: 0x000C111C
		// (set) Token: 0x06008810 RID: 34832 RVA: 0x000C2F60 File Offset: 0x000C1160
		public TFixedArray<float> Mins
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._Mins) == null)
				{
					result = (this._Mins = new TFixedArray<float>(base.NativePtr + (IntPtr)FCompressedTrack.__PropertyOffset_Mins, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Mins.CopyAssign(value);
			}
		}

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x06008811 RID: 34833 RVA: 0x000C2F70 File Offset: 0x000C1170
		// (set) Token: 0x06008812 RID: 34834 RVA: 0x000C2FB4 File Offset: 0x000C11B4
		public TFixedArray<float> Ranges
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._Ranges) == null)
				{
					result = (this._Ranges = new TFixedArray<float>(base.NativePtr + (IntPtr)FCompressedTrack.__PropertyOffset_Ranges, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Ranges.CopyAssign(value);
			}
		}

		// Token: 0x06008813 RID: 34835 RVA: 0x000C2FC2 File Offset: 0x000C11C2
		public FCompressedTrack()
		{
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x000C2FCA File Offset: 0x000C11CA
		public FCompressedTrack(TArray<byte> ByteStream, TArray<float> Times, TFixedArray<float> Mins, TFixedArray<float> Ranges)
		{
			this.ByteStream = ByteStream;
			this.Times = Times;
			this.Mins = Mins;
			this.Ranges = Ranges;
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x000C2FEF File Offset: 0x000C11EF
		protected override IntPtr GetUStructPtr()
		{
			return FCompressedTrack.StaticStruct();
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x000C2FFB File Offset: 0x000C11FB
		[NullableContext(2)]
		public FCompressedTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008817 RID: 34839 RVA: 0x000C3005 File Offset: 0x000C1205
		public FCompressedTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008818 RID: 34840 RVA: 0x000C3010 File Offset: 0x000C1210
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCompressedTrack(Pointer, false, true);
		}

		// Token: 0x06008819 RID: 34841 RVA: 0x000C301A File Offset: 0x000C121A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCompressedTrack(Pointer, MemoryOwner);
		}

		// Token: 0x040040AB RID: 16555
		public const string __ObjectPath = "/Script/Engine.CompressedTrack";

		// Token: 0x040040AC RID: 16556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040AD RID: 16557
		internal static int __PropertyOffset_ByteStream;

		// Token: 0x040040AE RID: 16558
		[Nullable(2)]
		private TArray<byte> _ByteStream;

		// Token: 0x040040AF RID: 16559
		internal static int __PropertyOffset_Times;

		// Token: 0x040040B0 RID: 16560
		[Nullable(2)]
		private TArray<float> _Times;

		// Token: 0x040040B1 RID: 16561
		internal static int __PropertyOffset_Mins;

		// Token: 0x040040B2 RID: 16562
		[Nullable(2)]
		private TFixedArray<float> _Mins;

		// Token: 0x040040B3 RID: 16563
		internal static int __PropertyOffset_Ranges;

		// Token: 0x040040B4 RID: 16564
		[Nullable(2)]
		private TFixedArray<float> _Ranges;
	}
}
