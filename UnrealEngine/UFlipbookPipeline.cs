using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027AD RID: 10157
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.FlipbookPipeline")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UFlipbookPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025D9E RID: 155038 RVA: 0x003962BA File Offset: 0x003944BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFlipbookPipeline._ClassPtr;
		}

		// Token: 0x06025D9F RID: 155039 RVA: 0x003962C8 File Offset: 0x003944C8
		public UFlipbookPipeline() : this(BuiltinUtils.AllocNativeUObject(UFlipbookPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025DA0 RID: 155040 RVA: 0x003962F0 File Offset: 0x003944F0
		public UFlipbookPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFlipbookPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170091DA RID: 37338
		// (get) Token: 0x06025DA1 RID: 155041 RVA: 0x00396324 File Offset: 0x00394524
		// (set) Token: 0x06025DA2 RID: 155042 RVA: 0x0039635D File Offset: 0x0039455D
		public FFlipbookPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FFlipbookPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FFlipbookPipelineSettings(base.NativePtr + (IntPtr)UFlipbookPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFlipbookPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UFlipbookPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025DA3 RID: 155043 RVA: 0x0039637E File Offset: 0x0039457E
		static UFlipbookPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.FlipbookPipeline");
		}

		// Token: 0x06025DA4 RID: 155044 RVA: 0x0039638C File Offset: 0x0039458C
		protected UFlipbookPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014A8C RID: 84620
		public new const string __ObjectPath = "/Script/SimplygonUObjects.FlipbookPipeline";

		// Token: 0x04014A8D RID: 84621
		private static IntPtr _ClassPtr;

		// Token: 0x04014A8E RID: 84622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014A8F RID: 84623
		internal static int __PropertyOffset_Settings;

		// Token: 0x04014A90 RID: 84624
		[Nullable(2)]
		private FFlipbookPipelineSettings _Settings;
	}
}
