using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002902 RID: 10498
	[UnrealObjectPath("/Script/TemplateSequence.CameraAnimationSequence")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UCameraAnimationSequence : UTemplateSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F14 RID: 159508 RVA: 0x003B6554 File Offset: 0x003B4754
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCameraAnimationSequence._ClassPtr;
		}

		// Token: 0x06026F15 RID: 159509 RVA: 0x003B6560 File Offset: 0x003B4760
		public UCameraAnimationSequence() : this(BuiltinUtils.AllocNativeUObject(UCameraAnimationSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F16 RID: 159510 RVA: 0x003B6588 File Offset: 0x003B4788
		[NullableContext(1)]
		public UCameraAnimationSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCameraAnimationSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026F17 RID: 159511 RVA: 0x003B65BB File Offset: 0x003B47BB
		static UCameraAnimationSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TemplateSequence.CameraAnimationSequence");
		}

		// Token: 0x06026F18 RID: 159512 RVA: 0x003B65C9 File Offset: 0x003B47C9
		protected UCameraAnimationSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040155F5 RID: 87541
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TemplateSequence.CameraAnimationSequence";

		// Token: 0x040155F6 RID: 87542
		private static IntPtr _ClassPtr;

		// Token: 0x040155F7 RID: 87543
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
