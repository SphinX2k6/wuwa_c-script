using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200106A RID: 4202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFDataList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRBFDataList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF0F RID: 61199 RVA: 0x0016292A File Offset: 0x00160B2A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFDataList._ScriptStructPtr != 0) ? FRBFDataList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFDataList", ref FRBFDataList._ScriptStructPtr);
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600EF10 RID: 61200 RVA: 0x00162950 File Offset: 0x00160B50
		// (set) Token: 0x0600EF11 RID: 61201 RVA: 0x00162993 File Offset: 0x00160B93
		public TArray<float> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<float>(base.NativePtr + (IntPtr)FRBFDataList.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x0600EF12 RID: 61202 RVA: 0x001629A1 File Offset: 0x00160BA1
		public FRBFDataList()
		{
		}

		// Token: 0x0600EF13 RID: 61203 RVA: 0x001629A9 File Offset: 0x00160BA9
		public FRBFDataList(TArray<float> Data)
		{
			this.Data = Data;
		}

		// Token: 0x0600EF14 RID: 61204 RVA: 0x001629B8 File Offset: 0x00160BB8
		protected override IntPtr GetUStructPtr()
		{
			return FRBFDataList.StaticStruct();
		}

		// Token: 0x0600EF15 RID: 61205 RVA: 0x001629C4 File Offset: 0x00160BC4
		[NullableContext(2)]
		public FRBFDataList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF16 RID: 61206 RVA: 0x001629CE File Offset: 0x00160BCE
		public FRBFDataList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF17 RID: 61207 RVA: 0x001629D9 File Offset: 0x00160BD9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFDataList(Pointer, false, true);
		}

		// Token: 0x0600EF18 RID: 61208 RVA: 0x001629E3 File Offset: 0x00160BE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFDataList(Pointer, MemoryOwner);
		}

		// Token: 0x0400815E RID: 33118
		public const string __ObjectPath = "/Script/Engine.RBFDataList";

		// Token: 0x0400815F RID: 33119
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008160 RID: 33120
		internal static int __PropertyOffset_Data;

		// Token: 0x04008161 RID: 33121
		[Nullable(2)]
		private TArray<float> _Data;
	}
}
