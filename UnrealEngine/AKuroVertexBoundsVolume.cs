using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D15 RID: 3349
	[UnrealObjectPath("/Script/Engine.KuroVertexBoundsVolume")]
	[UnrealStructLayout(1112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1112)]
	public class AKuroVertexBoundsVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B38B RID: 45963 RVA: 0x00100208 File Offset: 0x000FE408
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroVertexBoundsVolume._ClassPtr;
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x00100214 File Offset: 0x000FE414
		public AKuroVertexBoundsVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroVertexBoundsVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x0010023C File Offset: 0x000FE43C
		[NullableContext(1)]
		public AKuroVertexBoundsVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroVertexBoundsVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002909 RID: 10505
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x0010026F File Offset: 0x000FE46F
		// (set) Token: 0x0600B38F RID: 45967 RVA: 0x00100288 File Offset: 0x000FE488
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AKuroVertexBoundsVolume.__PropertyOffset_bEnabled) & AKuroVertexBoundsVolume.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AKuroVertexBoundsVolume.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)AKuroVertexBoundsVolume.__PropertyOffset_bEnabled) & ~AKuroVertexBoundsVolume.__PropertyMask_bEnabled) | (value ? AKuroVertexBoundsVolume.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x001002B8 File Offset: 0x000FE4B8
		static AKuroVertexBoundsVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroVertexBoundsVolume");
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x001002C6 File Offset: 0x000FE4C6
		protected AKuroVertexBoundsVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005E64 RID: 24164
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroVertexBoundsVolume";

		// Token: 0x04005E65 RID: 24165
		private static IntPtr _ClassPtr;

		// Token: 0x04005E66 RID: 24166
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005E67 RID: 24167
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04005E68 RID: 24168
		internal static byte __PropertyMask_bEnabled;
	}
}
