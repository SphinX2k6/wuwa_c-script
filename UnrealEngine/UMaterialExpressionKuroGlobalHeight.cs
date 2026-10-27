using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDB RID: 3547
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroGlobalHeight")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionKuroGlobalHeight : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C031 RID: 49201 RVA: 0x001140F2 File Offset: 0x001122F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroGlobalHeight._ClassPtr;
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x00114100 File Offset: 0x00112300
		public UMaterialExpressionKuroGlobalHeight() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalHeight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x00114128 File Offset: 0x00112328
		[NullableContext(1)]
		public UMaterialExpressionKuroGlobalHeight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGlobalHeight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0600C034 RID: 49204 RVA: 0x0011415C File Offset: 0x0011235C
		// (set) Token: 0x0600C035 RID: 49205 RVA: 0x00114195 File Offset: 0x00112395
		[Nullable(1)]
		public FExpressionInput InputPosition
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._InputPosition) == null)
				{
					result = (this._InputPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalHeight.__PropertyOffset_InputPosition, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalHeight.__PropertyOffset_InputPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C98 RID: 11416
		// (get) Token: 0x0600C036 RID: 49206 RVA: 0x001141B6 File Offset: 0x001123B6
		// (set) Token: 0x0600C037 RID: 49207 RVA: 0x001141CA File Offset: 0x001123CA
		public unsafe TEnumAsByte<EMaterialKuroGlobalHeightSampleSpace> SampleSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalHeight.__PropertyOffset_SampleSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionKuroGlobalHeight.__PropertyOffset_SampleSpace) = value;
			}
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x001141DF File Offset: 0x001123DF
		static UMaterialExpressionKuroGlobalHeight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroGlobalHeight");
		}

		// Token: 0x0600C039 RID: 49209 RVA: 0x001141ED File Offset: 0x001123ED
		protected UMaterialExpressionKuroGlobalHeight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065E8 RID: 26088
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroGlobalHeight";

		// Token: 0x040065E9 RID: 26089
		private static IntPtr _ClassPtr;

		// Token: 0x040065EA RID: 26090
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065EB RID: 26091
		internal static int __PropertyOffset_InputPosition;

		// Token: 0x040065EC RID: 26092
		[Nullable(2)]
		private FExpressionInput _InputPosition;

		// Token: 0x040065ED RID: 26093
		internal static int __PropertyOffset_SampleSpace;
	}
}
