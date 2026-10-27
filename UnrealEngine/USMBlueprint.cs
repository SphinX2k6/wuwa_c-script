using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200287D RID: 10365
	[UnrealObjectPath("/Script/SMSystem.SMBlueprint")]
	[UnrealStructLayout(1248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1248)]
	public class USMBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060265E9 RID: 157161 RVA: 0x003A4EB6 File Offset: 0x003A30B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USMBlueprint._ClassPtr;
		}

		// Token: 0x060265EA RID: 157162 RVA: 0x003A4EC4 File Offset: 0x003A30C4
		public USMBlueprint() : this(BuiltinUtils.AllocNativeUObject(USMBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060265EB RID: 157163 RVA: 0x003A4EEC File Offset: 0x003A30EC
		[NullableContext(1)]
		public USMBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USMBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093FD RID: 37885
		// (get) Token: 0x060265EC RID: 157164 RVA: 0x003A4F1F File Offset: 0x003A311F
		// (set) Token: 0x060265ED RID: 157165 RVA: 0x003A4F2F File Offset: 0x003A312F
		public unsafe int AssetVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USMBlueprint.__PropertyOffset_AssetVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USMBlueprint.__PropertyOffset_AssetVersion) = value;
			}
		}

		// Token: 0x060265EE RID: 157166 RVA: 0x003A4F40 File Offset: 0x003A3140
		static USMBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.SMBlueprint");
		}

		// Token: 0x060265EF RID: 157167 RVA: 0x003A4F4E File Offset: 0x003A314E
		protected USMBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040150AF RID: 86191
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMBlueprint";

		// Token: 0x040150B0 RID: 86192
		private static IntPtr _ClassPtr;

		// Token: 0x040150B1 RID: 86193
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040150B2 RID: 86194
		internal static int __PropertyOffset_AssetVersion;
	}
}
