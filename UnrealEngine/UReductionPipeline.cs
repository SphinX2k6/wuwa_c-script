using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027CB RID: 10187
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.ReductionPipeline")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UReductionPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025FAA RID: 155562 RVA: 0x00399540 File Offset: 0x00397740
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReductionPipeline._ClassPtr;
		}

		// Token: 0x06025FAB RID: 155563 RVA: 0x0039954C File Offset: 0x0039774C
		public UReductionPipeline() : this(BuiltinUtils.AllocNativeUObject(UReductionPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025FAC RID: 155564 RVA: 0x00399574 File Offset: 0x00397774
		public UReductionPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UReductionPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009277 RID: 37495
		// (get) Token: 0x06025FAD RID: 155565 RVA: 0x003995A8 File Offset: 0x003977A8
		// (set) Token: 0x06025FAE RID: 155566 RVA: 0x003995E1 File Offset: 0x003977E1
		public FReductionPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FReductionPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FReductionPipelineSettings(base.NativePtr + (IntPtr)UReductionPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FReductionPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UReductionPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025FAF RID: 155567 RVA: 0x00399602 File Offset: 0x00397802
		static UReductionPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.ReductionPipeline");
		}

		// Token: 0x06025FB0 RID: 155568 RVA: 0x00399610 File Offset: 0x00397810
		protected UReductionPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014BAF RID: 84911
		public new const string __ObjectPath = "/Script/SimplygonUObjects.ReductionPipeline";

		// Token: 0x04014BB0 RID: 84912
		private static IntPtr _ClassPtr;

		// Token: 0x04014BB1 RID: 84913
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014BB2 RID: 84914
		internal static int __PropertyOffset_Settings;

		// Token: 0x04014BB3 RID: 84915
		[Nullable(2)]
		private FReductionPipelineSettings _Settings;
	}
}
