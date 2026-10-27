using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDC RID: 3548
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroGrassInteraction")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionKuroGrassInteraction : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C03A RID: 49210 RVA: 0x001141F6 File Offset: 0x001123F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroGrassInteraction._ClassPtr;
		}

		// Token: 0x0600C03B RID: 49211 RVA: 0x00114204 File Offset: 0x00112404
		public UMaterialExpressionKuroGrassInteraction() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGrassInteraction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C03C RID: 49212 RVA: 0x0011422C File Offset: 0x0011242C
		public UMaterialExpressionKuroGrassInteraction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroGrassInteraction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C99 RID: 11417
		// (get) Token: 0x0600C03D RID: 49213 RVA: 0x00114260 File Offset: 0x00112460
		// (set) Token: 0x0600C03E RID: 49214 RVA: 0x00114299 File Offset: 0x00112499
		public FExpressionInput WorldPosition
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._WorldPosition) == null)
				{
					result = (this._WorldPosition = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionKuroGrassInteraction.__PropertyOffset_WorldPosition, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionKuroGrassInteraction.__PropertyOffset_WorldPosition, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C9A RID: 11418
		// (get) Token: 0x0600C03F RID: 49215 RVA: 0x001142BA File Offset: 0x001124BA
		// (set) Token: 0x0600C040 RID: 49216 RVA: 0x001142CA File Offset: 0x001124CA
		public unsafe EMaterialKuroInputType InputType
		{
			get
			{
				return (EMaterialKuroInputType)(*(base.NativePtr + (IntPtr)UMaterialExpressionKuroGrassInteraction.__PropertyOffset_InputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionKuroGrassInteraction.__PropertyOffset_InputType) = (byte)value;
			}
		}

		// Token: 0x0600C041 RID: 49217 RVA: 0x001142DB File Offset: 0x001124DB
		static UMaterialExpressionKuroGrassInteraction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroGrassInteraction");
		}

		// Token: 0x0600C042 RID: 49218 RVA: 0x001142E9 File Offset: 0x001124E9
		protected UMaterialExpressionKuroGrassInteraction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065EE RID: 26094
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroGrassInteraction";

		// Token: 0x040065EF RID: 26095
		private static IntPtr _ClassPtr;

		// Token: 0x040065F0 RID: 26096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065F1 RID: 26097
		internal static int __PropertyOffset_WorldPosition;

		// Token: 0x040065F2 RID: 26098
		[Nullable(2)]
		private FExpressionInput _WorldPosition;

		// Token: 0x040065F3 RID: 26099
		internal static int __PropertyOffset_InputType;
	}
}
