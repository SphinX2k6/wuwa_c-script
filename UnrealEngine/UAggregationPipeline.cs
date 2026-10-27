using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002774 RID: 10100
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.AggregationPipeline")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UAggregationPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025C0A RID: 154634 RVA: 0x003939BA File Offset: 0x00391BBA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAggregationPipeline._ClassPtr;
		}

		// Token: 0x06025C0B RID: 154635 RVA: 0x003939C8 File Offset: 0x00391BC8
		public UAggregationPipeline() : this(BuiltinUtils.AllocNativeUObject(UAggregationPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025C0C RID: 154636 RVA: 0x003939F0 File Offset: 0x00391BF0
		public UAggregationPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAggregationPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009154 RID: 37204
		// (get) Token: 0x06025C0D RID: 154637 RVA: 0x00393A24 File Offset: 0x00391C24
		// (set) Token: 0x06025C0E RID: 154638 RVA: 0x00393A5D File Offset: 0x00391C5D
		public FAggregationPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FAggregationPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FAggregationPipelineSettings(base.NativePtr + (IntPtr)UAggregationPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAggregationPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UAggregationPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025C0F RID: 154639 RVA: 0x00393A7E File Offset: 0x00391C7E
		static UAggregationPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.AggregationPipeline");
		}

		// Token: 0x06025C10 RID: 154640 RVA: 0x00393A8C File Offset: 0x00391C8C
		protected UAggregationPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148CF RID: 84175
		public new const string __ObjectPath = "/Script/SimplygonUObjects.AggregationPipeline";

		// Token: 0x040148D0 RID: 84176
		private static IntPtr _ClassPtr;

		// Token: 0x040148D1 RID: 84177
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148D2 RID: 84178
		internal static int __PropertyOffset_Settings;

		// Token: 0x040148D3 RID: 84179
		[Nullable(2)]
		private FAggregationPipelineSettings _Settings;
	}
}
