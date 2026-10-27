using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000846 RID: 2118
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimTextureFrameData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimTextureFrameData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600721D RID: 29213 RVA: 0x000A362B File Offset: 0x000A182B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTextureFrameData._ScriptStructPtr != 0) ? FAnimTextureFrameData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTextureFrameData", ref FAnimTextureFrameData._ScriptStructPtr);
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600721E RID: 29214 RVA: 0x000A3650 File Offset: 0x000A1850
		// (set) Token: 0x0600721F RID: 29215 RVA: 0x000A3693 File Offset: 0x000A1893
		public TArray<FVector> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<FVector>(base.NativePtr + (IntPtr)FAnimTextureFrameData.__PropertyOffset_Data, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x000A36A1 File Offset: 0x000A18A1
		public FAnimTextureFrameData()
		{
		}

		// Token: 0x06007221 RID: 29217 RVA: 0x000A36A9 File Offset: 0x000A18A9
		public FAnimTextureFrameData(TArray<FVector> Data)
		{
			this.Data = Data;
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x000A36B8 File Offset: 0x000A18B8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTextureFrameData.StaticStruct();
		}

		// Token: 0x06007223 RID: 29219 RVA: 0x000A36C4 File Offset: 0x000A18C4
		[NullableContext(2)]
		public FAnimTextureFrameData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007224 RID: 29220 RVA: 0x000A36CE File Offset: 0x000A18CE
		public FAnimTextureFrameData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007225 RID: 29221 RVA: 0x000A36D9 File Offset: 0x000A18D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTextureFrameData(Pointer, false, true);
		}

		// Token: 0x06007226 RID: 29222 RVA: 0x000A36E3 File Offset: 0x000A18E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTextureFrameData(Pointer, MemoryOwner);
		}

		// Token: 0x040036CC RID: 14028
		public const string __ObjectPath = "/Script/Engine.AnimTextureFrameData";

		// Token: 0x040036CD RID: 14029
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036CE RID: 14030
		internal static int __PropertyOffset_Data;

		// Token: 0x040036CF RID: 14031
		[Nullable(2)]
		private TArray<FVector> _Data;
	}
}
