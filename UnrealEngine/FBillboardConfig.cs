using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028D6 RID: 10454
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.BillboardConfig")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FBillboardConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026CB7 RID: 158903 RVA: 0x003B2A28 File Offset: 0x003B0C28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBillboardConfig._ScriptStructPtr != 0) ? FBillboardConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.BillboardConfig", ref FBillboardConfig._ScriptStructPtr);
		}

		// Token: 0x17009575 RID: 38261
		// (get) Token: 0x06026CB8 RID: 158904 RVA: 0x003B2A4C File Offset: 0x003B0C4C
		// (set) Token: 0x06026CB9 RID: 158905 RVA: 0x003B2A8F File Offset: 0x003B0C8F
		public TMap<string, string> Dimensions
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, string> result;
				if ((result = this._Dimensions) == null)
				{
					result = (this._Dimensions = new TMap<string, string>(base.NativePtr + (IntPtr)FBillboardConfig.__PropertyOffset_Dimensions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Dimensions.CopyAssign(value);
			}
		}

		// Token: 0x17009576 RID: 38262
		// (get) Token: 0x06026CBA RID: 158906 RVA: 0x003B2A9D File Offset: 0x003B0C9D
		// (set) Token: 0x06026CBB RID: 158907 RVA: 0x003B2AB1 File Offset: 0x003B0CB1
		public unsafe string BillboardUrl
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FBillboardConfig.__PropertyOffset_BillboardUrl)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FBillboardConfig.__PropertyOffset_BillboardUrl)), value);
			}
		}

		// Token: 0x06026CBC RID: 158908 RVA: 0x003B2AC6 File Offset: 0x003B0CC6
		public FBillboardConfig()
		{
		}

		// Token: 0x06026CBD RID: 158909 RVA: 0x003B2ACE File Offset: 0x003B0CCE
		public FBillboardConfig(TMap<string, string> Dimensions, string BillboardUrl)
		{
			this.Dimensions = Dimensions;
			this.BillboardUrl = BillboardUrl;
		}

		// Token: 0x06026CBE RID: 158910 RVA: 0x003B2AE4 File Offset: 0x003B0CE4
		protected override IntPtr GetUStructPtr()
		{
			return FBillboardConfig.StaticStruct();
		}

		// Token: 0x06026CBF RID: 158911 RVA: 0x003B2AF0 File Offset: 0x003B0CF0
		[NullableContext(2)]
		public FBillboardConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026CC0 RID: 158912 RVA: 0x003B2AFA File Offset: 0x003B0CFA
		public FBillboardConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026CC1 RID: 158913 RVA: 0x003B2B05 File Offset: 0x003B0D05
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBillboardConfig(Pointer, false, true);
		}

		// Token: 0x06026CC2 RID: 158914 RVA: 0x003B2B0F File Offset: 0x003B0D0F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBillboardConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040154B7 RID: 87223
		public const string __ObjectPath = "/Script/TapCommon.BillboardConfig";

		// Token: 0x040154B8 RID: 87224
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154B9 RID: 87225
		internal static int __PropertyOffset_Dimensions;

		// Token: 0x040154BA RID: 87226
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, string> _Dimensions;

		// Token: 0x040154BB RID: 87227
		internal static int __PropertyOffset_BillboardUrl;
	}
}
