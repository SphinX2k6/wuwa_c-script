using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200100F RID: 4111
	[UnrealObjectPath("/Script/Engine.PlayerStart")]
	[UnrealStructLayout(1104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class APlayerStart : ANavigationObjectBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600E0B5 RID: 57525 RVA: 0x0014A725 File Offset: 0x00148925
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerStart._ClassPtr;
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x0014A734 File Offset: 0x00148934
		public APlayerStart() : this(BuiltinUtils.AllocNativeUObject(APlayerStart.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x0014A75C File Offset: 0x0014895C
		[NullableContext(1)]
		public APlayerStart(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerStart.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600E0B8 RID: 57528 RVA: 0x0014A78F File Offset: 0x0014898F
		// (set) Token: 0x0600E0B9 RID: 57529 RVA: 0x0014A7A3 File Offset: 0x001489A3
		public unsafe FName PlayerStartTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerStart.__PropertyOffset_PlayerStartTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerStart.__PropertyOffset_PlayerStartTag) = value;
			}
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x0014A7B8 File Offset: 0x001489B8
		static APlayerStart()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerStart");
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x0014A7C6 File Offset: 0x001489C6
		protected APlayerStart(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040078B7 RID: 30903
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerStart";

		// Token: 0x040078B8 RID: 30904
		private static IntPtr _ClassPtr;

		// Token: 0x040078B9 RID: 30905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040078BA RID: 30906
		internal static int __PropertyOffset_PlayerStartTag;
	}
}
